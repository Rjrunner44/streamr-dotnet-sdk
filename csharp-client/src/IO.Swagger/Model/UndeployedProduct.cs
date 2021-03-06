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
    /// UndeployedProduct
    /// </summary>
    [DataContract]
    public partial class UndeployedProduct :  IEquatable<UndeployedProduct>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UndeployedProduct" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UndeployedProduct() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UndeployedProduct" /> class.
        /// </summary>
        /// <param name="blockNumber">Block number of associated Ethereum transaction (required).</param>
        /// <param name="blockIndex">Index of associated Ethereum transaction in block (required).</param>
        public UndeployedProduct(int? blockNumber = default(int?), int? blockIndex = default(int?))
        {
            // to ensure "blockNumber" is required (not null)
            if (blockNumber == null)
            {
                throw new InvalidDataException("blockNumber is a required property for UndeployedProduct and cannot be null");
            }
            else
            {
                this.BlockNumber = blockNumber;
            }
            // to ensure "blockIndex" is required (not null)
            if (blockIndex == null)
            {
                throw new InvalidDataException("blockIndex is a required property for UndeployedProduct and cannot be null");
            }
            else
            {
                this.BlockIndex = blockIndex;
            }
        }
        
        /// <summary>
        /// Block number of associated Ethereum transaction
        /// </summary>
        /// <value>Block number of associated Ethereum transaction</value>
        [DataMember(Name="blockNumber", EmitDefaultValue=false)]
        public int? BlockNumber { get; set; }

        /// <summary>
        /// Index of associated Ethereum transaction in block
        /// </summary>
        /// <value>Index of associated Ethereum transaction in block</value>
        [DataMember(Name="blockIndex", EmitDefaultValue=false)]
        public int? BlockIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UndeployedProduct {\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  BlockIndex: ").Append(BlockIndex).Append("\n");
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
            return this.Equals(input as UndeployedProduct);
        }

        /// <summary>
        /// Returns true if UndeployedProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of UndeployedProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UndeployedProduct input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BlockNumber == input.BlockNumber ||
                    (this.BlockNumber != null &&
                    this.BlockNumber.Equals(input.BlockNumber))
                ) && 
                (
                    this.BlockIndex == input.BlockIndex ||
                    (this.BlockIndex != null &&
                    this.BlockIndex.Equals(input.BlockIndex))
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
                if (this.BlockNumber != null)
                    hashCode = hashCode * 59 + this.BlockNumber.GetHashCode();
                if (this.BlockIndex != null)
                    hashCode = hashCode * 59 + this.BlockIndex.GetHashCode();
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
