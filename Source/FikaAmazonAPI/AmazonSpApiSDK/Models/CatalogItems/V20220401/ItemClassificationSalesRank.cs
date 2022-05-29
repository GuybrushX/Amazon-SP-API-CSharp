/* 
 * Selling Partner API for Catalog Items
 *
 * The Selling Partner API for Catalog Items provides programmatic access to information about items in the Amazon catalog.  For more information, refer to the [Catalog Items API Use Case Guide](doc:catalog-items-api-v2022-04-01-use-case-guide).
 *
 * OpenAPI spec version: 2022-04-01
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.CatalogItems.V20220401
{
    /// <summary>
    /// Sales rank of an Amazon catalog item by classification.
    /// </summary>
    [DataContract]
    public partial class ItemClassificationSalesRank : IEquatable<ItemClassificationSalesRank>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemClassificationSalesRank" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemClassificationSalesRank() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemClassificationSalesRank" /> class.
        /// </summary>
        /// <param name="classificationId">Identifier of the classification associated with the sales rank. (required).</param>
        /// <param name="title">Title, or name, of the sales rank. (required).</param>
        /// <param name="link">Corresponding Amazon retail website link, or URL, for the sales rank..</param>
        /// <param name="rank">Sales rank value. (required).</param>
        public ItemClassificationSalesRank(string classificationId = default(string), string title = default(string), string link = default(string), int? rank = default(int?))
        {
            // to ensure "classificationId" is required (not null)
            if (classificationId == null)
            {
                throw new InvalidDataException("classificationId is a required property for ItemClassificationSalesRank and cannot be null");
            }
            else
            {
                this.ClassificationId = classificationId;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for ItemClassificationSalesRank and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "rank" is required (not null)
            if (rank == null)
            {
                throw new InvalidDataException("rank is a required property for ItemClassificationSalesRank and cannot be null");
            }
            else
            {
                this.Rank = rank;
            }
            this.Link = link;
        }

        /// <summary>
        /// Identifier of the classification associated with the sales rank.
        /// </summary>
        /// <value>Identifier of the classification associated with the sales rank.</value>
        [DataMember(Name = "classificationId", EmitDefaultValue = false)]
        public string ClassificationId { get; set; }

        /// <summary>
        /// Title, or name, of the sales rank.
        /// </summary>
        /// <value>Title, or name, of the sales rank.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Corresponding Amazon retail website link, or URL, for the sales rank.
        /// </summary>
        /// <value>Corresponding Amazon retail website link, or URL, for the sales rank.</value>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public string Link { get; set; }

        /// <summary>
        /// Sales rank value.
        /// </summary>
        /// <value>Sales rank value.</value>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        public int? Rank { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemClassificationSalesRank {\n");
            sb.Append("  ClassificationId: ").Append(ClassificationId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
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
            return this.Equals(input as ItemClassificationSalesRank);
        }

        /// <summary>
        /// Returns true if ItemClassificationSalesRank instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemClassificationSalesRank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemClassificationSalesRank input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ClassificationId == input.ClassificationId ||
                    (this.ClassificationId != null &&
                    this.ClassificationId.Equals(input.ClassificationId))
                ) &&
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) &&
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) &&
                (
                    this.Rank == input.Rank ||
                    (this.Rank != null &&
                    this.Rank.Equals(input.Rank))
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
                if (this.ClassificationId != null)
                    hashCode = hashCode * 59 + this.ClassificationId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Rank != null)
                    hashCode = hashCode * 59 + this.Rank.GetHashCode();
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
