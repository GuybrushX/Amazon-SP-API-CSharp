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
    /// Current status of the inbound plan. Can be: ACTIVE, VOIDED, SHIPPED, ERRORED.
    /// </summary>
    /// <value>Current status of the inbound plan. Can be: ACTIVE, VOIDED, SHIPPED, ERRORED.

    [JsonConverter(typeof(StringEnumConverter))]
    public enum InboundPlanStatus
    {
        [EnumMember(Value = "ACTIVE")]
        ACTIVE = 1,

        [EnumMember(Value = "VOIDED")]
        VOIDED = 2,

        [EnumMember(Value = "SHIPPED")]
        SHIPPED = 3,

        [EnumMember(Value = "ERRORED")]
        ERRORED = 4
    }

}
