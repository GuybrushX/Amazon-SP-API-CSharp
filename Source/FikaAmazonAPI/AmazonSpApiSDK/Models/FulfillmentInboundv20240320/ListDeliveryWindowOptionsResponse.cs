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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInboundv20240320
{
    /// <summary>
    /// The listDeliveryWindowOptions response.
    /// </summary>
    [DataContract]
    public partial class ListDeliveryWindowOptionsResponse :  IEquatable<ListDeliveryWindowOptionsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListDeliveryWindowOptionsResponse" /> class.
        /// </summary>
        /// <param name="deliveryWindowOptions">Delivery window options generated for the placement option. (required).</param>
        /// <param name="pagination">pagination.</param>
        public ListDeliveryWindowOptionsResponse(List<DeliveryWindowOption> deliveryWindowOptions = default(List<DeliveryWindowOption>), Pagination pagination = default(Pagination))
        {
            // to ensure "deliveryWindowOptions" is required (not null)
            if (deliveryWindowOptions == null)
            {
                throw new InvalidDataException("deliveryWindowOptions is a required property for ListDeliveryWindowOptionsResponse and cannot be null");
            }
            else
            {
                this.DeliveryWindowOptions = deliveryWindowOptions;
            }
            this.Pagination = pagination;
        }
        
        public ListDeliveryWindowOptionsResponse()
        {
            this.DeliveryWindowOptions = default(List<DeliveryWindowOption>);
            this.Pagination = default(Pagination);
        }

        /// <summary>
        /// Delivery window options generated for the placement option.
        /// </summary>
        /// <value>Delivery window options generated for the placement option.</value>
        [DataMember(Name= "deliveryWindowOptions", EmitDefaultValue=false)]
        public List<DeliveryWindowOption> DeliveryWindowOptions { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name="pagination", EmitDefaultValue=false)]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDeliveryWindowOptionsResponse {\n");
            sb.Append("  DeliveryWindowOptions: ").Append(DeliveryWindowOptions).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
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
            return this.Equals(input as ListDeliveryWindowOptionsResponse);
        }

        /// <summary>
        /// Returns true if ListDeliveryWindowOptionsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListDeliveryWindowOptionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListDeliveryWindowOptionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeliveryWindowOptions == input.DeliveryWindowOptions ||
                    this.DeliveryWindowOptions != null &&
                    this.DeliveryWindowOptions.SequenceEqual(input.DeliveryWindowOptions)
                ) && 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
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
                if (this.DeliveryWindowOptions != null)
                    hashCode = hashCode * 59 + this.DeliveryWindowOptions.GetHashCode();
                if (this.Pagination != null)
                    hashCode = hashCode * 59 + this.Pagination.GetHashCode();
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
            yield break;
        }
    }

}
