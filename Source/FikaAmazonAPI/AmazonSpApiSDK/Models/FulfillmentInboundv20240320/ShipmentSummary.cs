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
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInboundv20240320
{
    /// <summary>
    /// Summary information about a shipment.
    /// </summary>
    [DataContract]
    public partial class ShipmentSummary :  IEquatable<ShipmentSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ShipmentSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentSummary" /> class.
        /// </summary>
        /// <param name="shipmentId">Identifier to a shipment. A shipment contains the boxes and units being inbounded. (required).</param>
        /// <param name="status">The status of a shipment. The state of the shipment will typically start in UNCONFIRMED, then transition to WORKING after a placement option has been confirmed, and then to READY_TO_SHIP once labels are generated. Can be ABANDONED, CANCELLED, CHECKED_IN, CLOSED, DELETED, DELIVERED, IN_TRANSIT, MIXED, READY_TO_SHIP, RECEIVING, SHIPPED, UNCONFIRMED, or WORKING. (required).</param>
        public ShipmentSummary(string shipmentId = default(string), ShipmentStatus status = default(ShipmentStatus))
        {
            // to ensure "shipmentId" is required (not null)
            if (shipmentId == null)
            {
                throw new InvalidDataException("shipmentId is a required property for ShipmentSummary and cannot be null");
            }
            else
            {
                this.ShipmentId = shipmentId;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for ShipmentSummary and cannot be null");
            }
            else
            {
                this.Status = status;
            }
        }
        
        /// <summary>
        /// Identifier to a shipment. A shipment contains the boxes and units being inbounded.
        /// </summary>
        /// <value>Identifier to a shipment. A shipment contains the boxes and units being inbounded.</value>
        [DataMember(Name="shipmentId", EmitDefaultValue=false)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// The status of a shipment. The state of the shipment will typically start in UNCONFIRMED, then transition to WORKING after a placement option has been confirmed, and then to READY_TO_SHIP once labels are generated. Can be ABANDONED, CANCELLED, CHECKED_IN, CLOSED, DELETED, DELIVERED, IN_TRANSIT, MIXED, READY_TO_SHIP, RECEIVING, SHIPPED, UNCONFIRMED, or WORKING.
        /// </summary>
        /// <value>The status of a shipment. The state of the shipment will typically start in UNCONFIRMED, then transition to WORKING after a placement option has been confirmed, and then to READY_TO_SHIP once labels are generated. Can be ABANDONED, CANCELLED, CHECKED_IN, CLOSED, DELETED, DELIVERED, IN_TRANSIT, MIXED, READY_TO_SHIP, RECEIVING, SHIPPED, UNCONFIRMED, or WORKING.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public ShipmentStatus Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipmentSummary {\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShipmentSummary);
        }

        /// <summary>
        /// Returns true if ShipmentSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShipmentId == input.ShipmentId ||
                    (this.ShipmentId != null &&
                    this.ShipmentId.Equals(input.ShipmentId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ShipmentId != null)
                    hashCode = hashCode * 59 + this.ShipmentId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // ShipmentId (string) maxLength
            if(this.ShipmentId != null && this.ShipmentId.Length > 38)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShipmentId, length must be less than 38.", new [] { "ShipmentId" });
            }

            // ShipmentId (string) minLength
            if(this.ShipmentId != null && this.ShipmentId.Length < 38)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShipmentId, length must be greater than 38.", new [] { "ShipmentId" });
            }

            // ShipmentId (string) pattern
            Regex regexShipmentId = new Regex(@"^[a-zA-Z0-9-]*$", RegexOptions.CultureInvariant);
            if (false == regexShipmentId.Match(this.ShipmentId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShipmentId, must match a pattern of " + regexShipmentId, new [] { "ShipmentId" });
            }

            yield break;
        }
    }

}
