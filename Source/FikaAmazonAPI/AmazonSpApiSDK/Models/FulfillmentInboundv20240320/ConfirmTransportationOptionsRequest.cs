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
    /// The &#x60;confirmTransportationOptions&#x60; request.
    /// </summary>
    [DataContract]
    public partial class ConfirmTransportationOptionsRequest :  IEquatable<ConfirmTransportationOptionsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmTransportationOptionsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ConfirmTransportationOptionsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmTransportationOptionsRequest" /> class.
        /// </summary>
        /// <param name="transportationSelections">Information needed to confirm one of the available transportation options. (required).</param>
        public ConfirmTransportationOptionsRequest(List<TransportationSelection> transportationSelections = default(List<TransportationSelection>))
        {
            // to ensure "transportationSelections" is required (not null)
            if (transportationSelections == null)
            {
                throw new InvalidDataException("transportationSelections is a required property for ConfirmTransportationOptionsRequest and cannot be null");
            }
            else
            {
                this.TransportationSelections = transportationSelections;
            }
        }
        
        /// <summary>
        /// Information needed to confirm one of the available transportation options.
        /// </summary>
        /// <value>Information needed to confirm one of the available transportation options.</value>
        [DataMember(Name="transportationSelections", EmitDefaultValue=false)]
        public List<TransportationSelection> TransportationSelections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfirmTransportationOptionsRequest {\n");
            sb.Append("  TransportationSelections: ").Append(TransportationSelections).Append("\n");
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
            return this.Equals(input as ConfirmTransportationOptionsRequest);
        }

        /// <summary>
        /// Returns true if ConfirmTransportationOptionsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfirmTransportationOptionsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfirmTransportationOptionsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransportationSelections == input.TransportationSelections ||
                    this.TransportationSelections != null &&
                    this.TransportationSelections.SequenceEqual(input.TransportationSelections)
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
                if (this.TransportationSelections != null)
                    hashCode = hashCode * 59 + this.TransportationSelections.GetHashCode();
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
