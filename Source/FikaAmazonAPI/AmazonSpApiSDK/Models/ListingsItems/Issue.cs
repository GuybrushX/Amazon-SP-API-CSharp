/* 
 * Selling Partner API for Listings Items
 *
 * The Selling Partner API for Listings Items (Listings Items API) provides programmatic access to selling partner listings on Amazon. Use this API in collaboration with the Selling Partner API for Product Type Definitions, which you use to retrieve the information about Amazon product types needed to use the Listings Items API.  For more information, see the [Listings Items API Use Case Guide](doc:listings-items-api-v2021-08-01-use-case-guide).
 *
 * OpenAPI spec version: 2021-08-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ListingsItems
{
    /// <summary>
    /// An issue with a listings item.
    /// </summary>
    [DataContract]
    public partial class Issue :  IEquatable<Issue>, IValidatableObject
    {
        /// <summary>
        /// The severity of the issue.
        /// </summary>
        /// <value>The severity of the issue.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SeverityEnum
        {
            
            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR = 1,
            
            /// <summary>
            /// Enum WARNING for value: WARNING
            /// </summary>
            [EnumMember(Value = "WARNING")]
            WARNING = 2,
            
            /// <summary>
            /// Enum INFO for value: INFO
            /// </summary>
            [EnumMember(Value = "INFO")]
            INFO = 3
        }

        /// <summary>
        /// The severity of the issue.
        /// </summary>
        /// <value>The severity of the issue.</value>
        [DataMember(Name="severity", EmitDefaultValue=false)]
        public SeverityEnum Severity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Issue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Issue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Issue" /> class.
        /// </summary>
        /// <param name="code">An issue code that identifies the type of issue. (required).</param>
        /// <param name="message">A message that describes the issue. (required).</param>
        /// <param name="severity">The severity of the issue. (required).</param>
        /// <param name="attributeNames">Names of the attributes associated with the issue, if applicable..</param>
        public Issue(string code = default(string), string message = default(string), SeverityEnum severity = default(SeverityEnum), List<string> attributeNames = default(List<string>))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for Issue and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new InvalidDataException("message is a required property for Issue and cannot be null");
            }
            else
            {
                this.Message = message;
            }
            // to ensure "severity" is required (not null)
            if (severity == null)
            {
                throw new InvalidDataException("severity is a required property for Issue and cannot be null");
            }
            else
            {
                this.Severity = severity;
            }
            this.AttributeNames = attributeNames;
        }
        
        /// <summary>
        /// An issue code that identifies the type of issue.
        /// </summary>
        /// <value>An issue code that identifies the type of issue.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// A message that describes the issue.
        /// </summary>
        /// <value>A message that describes the issue.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }


        /// <summary>
        /// Names of the attributes associated with the issue, if applicable.
        /// </summary>
        /// <value>Names of the attributes associated with the issue, if applicable.</value>
        [DataMember(Name="attributeNames", EmitDefaultValue=false)]
        public List<string> AttributeNames { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Issue {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  AttributeNames: ").Append(AttributeNames).Append("\n");
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
            return this.Equals(input as Issue);
        }

        /// <summary>
        /// Returns true if Issue instances are equal
        /// </summary>
        /// <param name="input">Instance of Issue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Issue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Severity == input.Severity ||
                    (this.Severity != null &&
                    this.Severity.Equals(input.Severity))
                ) && 
                (
                    this.AttributeNames == input.AttributeNames ||
                    this.AttributeNames != null &&
                    this.AttributeNames.SequenceEqual(input.AttributeNames)
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Severity != null)
                    hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.AttributeNames != null)
                    hashCode = hashCode * 59 + this.AttributeNames.GetHashCode();
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
