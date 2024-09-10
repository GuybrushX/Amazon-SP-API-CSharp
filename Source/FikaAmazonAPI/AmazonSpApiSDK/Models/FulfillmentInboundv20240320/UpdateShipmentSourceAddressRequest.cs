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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInboundv20240320
{
    /// <summary>
    /// The UpdateShipmentSourceAddress request.
    /// </summary>
    [DataContract]
    public partial class UpdateShipmentSourceAddressRequest :  IEquatable<UpdateShipmentSourceAddressRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShipmentSourceAddressRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public UpdateShipmentSourceAddressRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShipmentSourceAddressRequest" /> class.
        /// </summary>
        /// <param name="address">Specific details to identify a place. (required).</param>
        public UpdateShipmentSourceAddressRequest(AddressInput address = default(AddressInput))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for UpdateShipmentSourceAddressRequest and cannot be null");
            }
            else
            {
                this.Address = address;
            }
        }

        /// <summary>
        /// Specific details to identify a place.
        /// </summary>
        /// <value>Specific details to identify a place.</value>
        [DataMember(Name= "address", EmitDefaultValue=false)]
        public AddressInput Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateShipmentSourceAddressRequest {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as UpdateShipmentSourceAddressRequest);
        }

        /// <summary>
        /// Returns true if UpdateShipmentSourceAddressRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateShipmentSourceAddressRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateShipmentSourceAddressRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
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
