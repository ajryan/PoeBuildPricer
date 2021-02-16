/*
 * poe.ninja API
 *
 * Public API of poe.ninja (mainly economy for now).
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = PoeNinjaApi.Client.OpenAPIDateConverter;

namespace PoeNinjaApi.Model
{
    /// <summary>
    /// GemSnapshot
    /// </summary>
    [DataContract(Name = "GemSnapshot")]
    public partial class GemSnapshot : IEquatable<GemSnapshot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GemSnapshot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GemSnapshot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GemSnapshot" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="itemData">itemData.</param>
        /// <param name="level">level (required).</param>
        /// <param name="quality">quality (required).</param>
        public GemSnapshot(string name = default(string), ItemData itemData = default(ItemData), int level = default(int), int quality = default(int))
        {
            this.Level = level;
            this.Quality = quality;
            this.Name = name;
            this.ItemData = itemData;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ItemData
        /// </summary>
        [DataMember(Name = "itemData", EmitDefaultValue = false)]
        public ItemData ItemData { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", IsRequired = true, EmitDefaultValue = false)]
        public int Level { get; set; }

        /// <summary>
        /// Gets or Sets Quality
        /// </summary>
        [DataMember(Name = "quality", IsRequired = true, EmitDefaultValue = false)]
        public int Quality { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GemSnapshot {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ItemData: ").Append(ItemData).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GemSnapshot);
        }

        /// <summary>
        /// Returns true if GemSnapshot instances are equal
        /// </summary>
        /// <param name="input">Instance of GemSnapshot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GemSnapshot input)
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
                    this.ItemData == input.ItemData ||
                    (this.ItemData != null &&
                    this.ItemData.Equals(input.ItemData))
                ) && 
                (
                    this.Level == input.Level ||
                    this.Level.Equals(input.Level)
                ) && 
                (
                    this.Quality == input.Quality ||
                    this.Quality.Equals(input.Quality)
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
                if (this.ItemData != null)
                    hashCode = hashCode * 59 + this.ItemData.GetHashCode();
                hashCode = hashCode * 59 + this.Level.GetHashCode();
                hashCode = hashCode * 59 + this.Quality.GetHashCode();
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