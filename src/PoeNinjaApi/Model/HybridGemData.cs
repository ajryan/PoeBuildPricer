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
    /// HybridGemData
    /// </summary>
    [DataContract(Name = "HybridGemData")]
    public partial class HybridGemData : IEquatable<HybridGemData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HybridGemData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HybridGemData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HybridGemData" /> class.
        /// </summary>
        /// <param name="baseTypeName">baseTypeName.</param>
        /// <param name="isVaalGem">isVaalGem (required).</param>
        /// <param name="properties">properties.</param>
        /// <param name="explicitMods">explicitMods.</param>
        /// <param name="secDescrText">secDescrText.</param>
        public HybridGemData(string baseTypeName = default(string), bool isVaalGem = default(bool), List<PropertyData> properties = default(List<PropertyData>), List<string> explicitMods = default(List<string>), string secDescrText = default(string))
        {
            this.IsVaalGem = isVaalGem;
            this.BaseTypeName = baseTypeName;
            this.Properties = properties;
            this.ExplicitMods = explicitMods;
            this.SecDescrText = secDescrText;
        }

        /// <summary>
        /// Gets or Sets BaseTypeName
        /// </summary>
        [DataMember(Name = "baseTypeName", EmitDefaultValue = false)]
        public string BaseTypeName { get; set; }

        /// <summary>
        /// Gets or Sets IsVaalGem
        /// </summary>
        [DataMember(Name = "isVaalGem", IsRequired = true, EmitDefaultValue = false)]
        public bool IsVaalGem { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public List<PropertyData> Properties { get; set; }

        /// <summary>
        /// Gets or Sets ExplicitMods
        /// </summary>
        [DataMember(Name = "explicitMods", EmitDefaultValue = false)]
        public List<string> ExplicitMods { get; set; }

        /// <summary>
        /// Gets or Sets SecDescrText
        /// </summary>
        [DataMember(Name = "secDescrText", EmitDefaultValue = false)]
        public string SecDescrText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HybridGemData {\n");
            sb.Append("  BaseTypeName: ").Append(BaseTypeName).Append("\n");
            sb.Append("  IsVaalGem: ").Append(IsVaalGem).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  ExplicitMods: ").Append(ExplicitMods).Append("\n");
            sb.Append("  SecDescrText: ").Append(SecDescrText).Append("\n");
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
            return this.Equals(input as HybridGemData);
        }

        /// <summary>
        /// Returns true if HybridGemData instances are equal
        /// </summary>
        /// <param name="input">Instance of HybridGemData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HybridGemData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BaseTypeName == input.BaseTypeName ||
                    (this.BaseTypeName != null &&
                    this.BaseTypeName.Equals(input.BaseTypeName))
                ) && 
                (
                    this.IsVaalGem == input.IsVaalGem ||
                    this.IsVaalGem.Equals(input.IsVaalGem)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.ExplicitMods == input.ExplicitMods ||
                    this.ExplicitMods != null &&
                    input.ExplicitMods != null &&
                    this.ExplicitMods.SequenceEqual(input.ExplicitMods)
                ) && 
                (
                    this.SecDescrText == input.SecDescrText ||
                    (this.SecDescrText != null &&
                    this.SecDescrText.Equals(input.SecDescrText))
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
                if (this.BaseTypeName != null)
                    hashCode = hashCode * 59 + this.BaseTypeName.GetHashCode();
                hashCode = hashCode * 59 + this.IsVaalGem.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.ExplicitMods != null)
                    hashCode = hashCode * 59 + this.ExplicitMods.GetHashCode();
                if (this.SecDescrText != null)
                    hashCode = hashCode * 59 + this.SecDescrText.GetHashCode();
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
