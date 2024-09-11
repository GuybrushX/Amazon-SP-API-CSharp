/* 
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInboundv20240320
{
    /// <summary>
    /// Type of incentive. Can be: FEE, DISCOUNT.
    /// </summary>
    /// <value>Type of incentive. Can be: FEE, DISCOUNT.

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IncentiveType
    {
        [EnumMember(Value = "FEE")]
        FEE = 1,

        [EnumMember(Value = "DISCOUNT")]
        DISCOUNT = 2,

    }

}
