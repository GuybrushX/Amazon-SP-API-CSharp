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
    /// The confirmDeliveryWindowOptions response.
    /// </summary>
    [DataContract]
    public partial class ConfirmDeliveryWindowOptionsResponse :  IEquatable<ConfirmDeliveryWindowOptionsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmDeliveryWindowOptionsResponse" /> class.
        /// </summary>
        /// <param name="operationId">UUID for the given operation. (required).</param>
        public ConfirmDeliveryWindowOptionsResponse(string operationId = default(string))
        {
            // to ensure "operationId" is required (not null)
            if (operationId == null)
            {
                throw new InvalidDataException("operationId is a required property for ConfirmDeliveryWindowOptionsResponse and cannot be null");
            }
            else
            {
                this.OperationId = operationId;
            }
        }
        public ConfirmDeliveryWindowOptionsResponse()
        {
            this.OperationId = default(string);
        }

        /// <summary>
        /// UUID for the given operation.
        /// </summary>
        /// <value>UUID for the given operation.</value>
        [DataMember(Name="operationId", EmitDefaultValue=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfirmDeliveryWindowOptionsResponse {\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
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
            return this.Equals(input as ConfirmDeliveryWindowOptionsResponse);
        }

        /// <summary>
        /// Returns true if ConfirmDeliveryWindowOptionsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfirmDeliveryWindowOptionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfirmDeliveryWindowOptionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OperationId == input.OperationId ||
                    (this.OperationId != null &&
                    this.OperationId.Equals(input.OperationId))
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
                if (this.OperationId != null)
                    hashCode = hashCode * 59 + this.OperationId.GetHashCode();
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
            // OperationId (string) maxLength
            if(this.OperationId != null && this.OperationId.Length > 38)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OperationId, length must be less than 38.", new [] { "OperationId" });
            }

            // OperationId (string) minLength
            if(this.OperationId != null && this.OperationId.Length < 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OperationId, length must be greater than 36.", new [] { "OperationId" });
            }

            // OperationId (string) pattern
            Regex regexOperationId = new Regex(@"^[a-zA-Z0-9-]*$", RegexOptions.CultureInvariant);
            if (false == regexOperationId.Match(this.OperationId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OperationId, must match a pattern of " + regexOperationId, new [] { "OperationId" });
            }

            yield break;
        }
    }

}
