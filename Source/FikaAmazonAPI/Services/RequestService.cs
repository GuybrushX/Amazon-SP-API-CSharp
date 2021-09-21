﻿using FikaAmazonAPI.AmazonSpApiSDK.Models;
using FikaAmazonAPI.AmazonSpApiSDK.Models.CatalogItems;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Exceptions;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Filters;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Orders;
using FikaAmazonAPI.AmazonSpApiSDK.Services;
using FikaAmazonAPI.Utils;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using RestSharp.Serializers;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Token;
using static FikaAmazonAPI.AmazonSpApiSDK.Models.Token.CacheTokenData;
using FikaAmazonAPI.Search;

namespace FikaAmazonAPI.Services
{
    public class RequestService : ApiUrls
    {
        private string AccessTokenHeaderName = "x-amz-access-token";
        protected RestClient RequestClient { get; set; }
        protected IRestRequest Request { get; set; }
        protected AmazonCredential AmazonCredential { get; set; }
        protected MarketPlace MarketPlace { get; set; }
        protected string AmazonSandboxUrl { get; set; }
        protected string AmazonProductionUrl { get; set; }
        protected string AccessToken { get; set; }

        protected string ApiBaseUrl
        {
            get
            {
                return EnvironemntManager.Environemnt == EnvironemntManager.Environments.Sandbox ? AmazonSandboxUrl : AmazonProductionUrl;
            }
        }

        /// <summary>
        /// Creates request base service
        /// </summary>
        /// <param name="awsCredentials">Contains api clients information</param>
        /// <param name="clientToken">Contains current user's account api keys</param>
        public RequestService(AmazonCredential amazonCredential)
        {
            AmazonCredential = amazonCredential;
            AmazonSandboxUrl = amazonCredential.MarketPlace.Region.SandboxHostUrl;
            AmazonProductionUrl = amazonCredential.MarketPlace.Region.HostUrl;

            MarketPlace = amazonCredential.MarketPlace;
            
        }


        private void CreateRequest(string url, RestSharp.Method method)
        {
            RequestClient = new RestClient(ApiBaseUrl);
            Request = new RestRequest(url, method);
        }



        protected void CreateAuthorizedRequest(string url, RestSharp.Method method, List<KeyValuePair<string, string>> queryParameters = null,object postJsonObj=null, TokenDataType tokenDataType=TokenDataType.Normal,object parameter=null)
        {
            var PiiObject = parameter as IParameterBasedPII;
            if (PiiObject != null && PiiObject.IsNeedRestrictedDataToken)
            {
                RefreshToken(TokenDataType.PII, PiiObject.RestrictedDataTokenRequest);
            }
            else RefreshToken(tokenDataType);
            CreateRequest(url, method);
            if (postJsonObj != null)
                AddJsonBody(postJsonObj);
            if (queryParameters!=null)
                AddQueryParameters(queryParameters);

            AddAccessToken();
        }

        protected void CreateAuthorizedPagedRequest(AmazonFilter filter, string url, RestSharp.Method method)
        {
            RefreshToken();
            if (filter.NextPage != null)
                CreateRequest(filter.NextPage, method);
            else
            {
                CreateRequest(url, method);
                AddLimitHeader(filter.Limit);
            }
            AddAccessToken();
        }

        /// <summary>
        /// Executes the request
        /// </summary>
        /// <typeparam name="T">Type to parse response to</typeparam>
        /// <returns>Returns data of T type</returns>
        protected T ExecuteRequest<T>() where T : new()
        {
            Request = TokenGeneration.SignWithSTSKeysAndSecurityToken(Request, RequestClient.BaseUrl.Host, AmazonCredential);
            var response = RequestClient.Execute<T>(Request);
            //response.Headers
            ///TODO
            ///x-amzn-RateLimit-Limit
            ///https://github.com/gilyas/selling-partner-api-bootstrap/blob/2f075c1690882bdc3b1e8e916f67ec88f14b36d1/lambda/src/main/java/cn/amazon/aws/rp/spapi/lambda/requestlimiter/ApiProxy.java#L147

            ParseResponse(response);
            if (response.StatusCode==HttpStatusCode.OK && !string.IsNullOrEmpty(response.Content) && response.Data == null)
            {
                response.Data = JsonConvert.DeserializeObject<T>(response.Content);
            }
            return response.Data;
        }

        /// <summary>
        /// Executes the request 
        /// </summary>
        /// <typeparam name="T">Type to parse response to</typeparam>
        /// <returns>Returns raw response</returns>
        protected IRestResponse ExecuteRequest()
        {
            var response = RequestClient.Execute(Request);
            ParseResponse(response);
            return response;
        }

        protected void ParseResponse(IRestResponse response)
        {
            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted || response.StatusCode == HttpStatusCode.Created)
                return;
            if (response.StatusCode == HttpStatusCode.NotFound)
                throw new NotFoundException("Resource that you are looking for is not found", response);
            else
            {
                Console.WriteLine("Amazon Api didn't respond with Okay, see exception for more details"+ response.Content);
                throw new AmazonException("Amazon Api didn't respond with Okay, see exception for more details", response);
            }
                
        }

        protected void AddQueryParameters(List<KeyValuePair<string, string>> queryParameters)
        {
            if (queryParameters != null)
                queryParameters.ForEach(qp => Request.AddQueryParameter(qp.Key, qp.Value));
        }

        protected void AddLimitHeader(int limit)
        {
            Request.AddQueryParameter("limit", limit.ToString());
        }
        protected void AddJsonBody(object jsonData)
        {
            //Request.JsonSerializer = new JsonNetSerializer();
            var json = JsonConvert.SerializeObject(jsonData);
            Request.AddJsonBody(json);
        }
        protected void AddAccessToken()
        {
            Request.AddHeader(AccessTokenHeaderName, AccessToken);
        }

        protected void RefreshToken(TokenDataType tokenDataType=TokenDataType.Normal, CreateRestrictedDataTokenRequest requestPII = null)
        {
            var token = AmazonCredential.CacheTokenData.GetToken(tokenDataType);
            if(token==null)
            {
                if(tokenDataType== TokenDataType.PII)
                {
                    var pii = CreateRestrictedDataToken(requestPII);
                    token=new TokenResponse()
                    {
                        access_token = pii.RestrictedDataToken,
                        expires_in = pii.ExpiresIn
                    };

                }
                else
                {
                    token = TokenGeneration.RefreshAccessToken(AmazonCredential, tokenDataType);
                }

                AmazonCredential.CacheTokenData.SetToken(tokenDataType, token);
            }
                

            AccessToken = token.access_token;
        }

        public CreateRestrictedDataTokenData CreateRestrictedDataToken(CreateRestrictedDataTokenRequest createRestrictedDataTokenRequest)
        {
            CreateAuthorizedRequest(TokenApiUrls.RestrictedDataToken, RestSharp.Method.POST, postJsonObj: createRestrictedDataTokenRequest);
            var response = ExecuteRequest<CreateRestrictedDataTokenResponse>();
            if(response!=null && response.Payload!=null)
                return response.Payload;
            return null;
        }
    }

}