/* 
 * Streamr API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// ProductWithoutBlockchain
    /// </summary>
    [DataContract]
    public partial class ProductWithoutBlockchain :  IEquatable<ProductWithoutBlockchain>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductWithoutBlockchain" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductWithoutBlockchain() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductWithoutBlockchain" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="category">identifier of Category this Product belong to (required).</param>
        /// <param name="streams">List of Stream identifiers that belong to this Product (required).</param>
        /// <param name="previewStream">Identifier of Stream selected for preview.</param>
        /// <param name="previewConfigJson">Configuration of previewStream.</param>
        public ProductWithoutBlockchain(string name = default(string), string description = default(string), string category = default(string), List<string> streams = default(List<string>), string previewStream = default(string), string previewConfigJson = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ProductWithoutBlockchain and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for ProductWithoutBlockchain and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "category" is required (not null)
            if (category == null)
            {
                throw new InvalidDataException("category is a required property for ProductWithoutBlockchain and cannot be null");
            }
            else
            {
                this.Category = category;
            }
            // to ensure "streams" is required (not null)
            if (streams == null)
            {
                throw new InvalidDataException("streams is a required property for ProductWithoutBlockchain and cannot be null");
            }
            else
            {
                this.Streams = streams;
            }
            this.PreviewStream = previewStream;
            this.PreviewConfigJson = previewConfigJson;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// identifier of Category this Product belong to
        /// </summary>
        /// <value>identifier of Category this Product belong to</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// List of Stream identifiers that belong to this Product
        /// </summary>
        /// <value>List of Stream identifiers that belong to this Product</value>
        [DataMember(Name="streams", EmitDefaultValue=false)]
        public List<string> Streams { get; set; }

        /// <summary>
        /// Identifier of Stream selected for preview
        /// </summary>
        /// <value>Identifier of Stream selected for preview</value>
        [DataMember(Name="previewStream", EmitDefaultValue=false)]
        public string PreviewStream { get; set; }

        /// <summary>
        /// Configuration of previewStream
        /// </summary>
        /// <value>Configuration of previewStream</value>
        [DataMember(Name="previewConfigJson", EmitDefaultValue=false)]
        public string PreviewConfigJson { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductWithoutBlockchain {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Streams: ").Append(Streams).Append("\n");
            sb.Append("  PreviewStream: ").Append(PreviewStream).Append("\n");
            sb.Append("  PreviewConfigJson: ").Append(PreviewConfigJson).Append("\n");
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
            return this.Equals(input as ProductWithoutBlockchain);
        }

        /// <summary>
        /// Returns true if ProductWithoutBlockchain instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductWithoutBlockchain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductWithoutBlockchain input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Streams == input.Streams ||
                    this.Streams != null &&
                    this.Streams.SequenceEqual(input.Streams)
                ) && 
                (
                    this.PreviewStream == input.PreviewStream ||
                    (this.PreviewStream != null &&
                    this.PreviewStream.Equals(input.PreviewStream))
                ) && 
                (
                    this.PreviewConfigJson == input.PreviewConfigJson ||
                    (this.PreviewConfigJson != null &&
                    this.PreviewConfigJson.Equals(input.PreviewConfigJson))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Streams != null)
                    hashCode = hashCode * 59 + this.Streams.GetHashCode();
                if (this.PreviewStream != null)
                    hashCode = hashCode * 59 + this.PreviewStream.GetHashCode();
                if (this.PreviewConfigJson != null)
                    hashCode = hashCode * 59 + this.PreviewConfigJson.GetHashCode();
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
