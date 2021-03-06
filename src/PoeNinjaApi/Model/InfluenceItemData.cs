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
    /// InfluenceItemData
    /// </summary>
    [DataContract(Name = "InfluenceItemData")]
    public partial class InfluenceItemData : IEquatable<InfluenceItemData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfluenceItemData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfluenceItemData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfluenceItemData" /> class.
        /// </summary>
        /// <param name="shaper">shaper (required).</param>
        /// <param name="elder">elder (required).</param>
        /// <param name="crusader">crusader (required).</param>
        /// <param name="redeemer">redeemer (required).</param>
        /// <param name="hunter">hunter (required).</param>
        /// <param name="warlord">warlord (required).</param>
        public InfluenceItemData(bool shaper = default(bool), bool elder = default(bool), bool crusader = default(bool), bool redeemer = default(bool), bool hunter = default(bool), bool warlord = default(bool))
        {
            this.Shaper = shaper;
            this.Elder = elder;
            this.Crusader = crusader;
            this.Redeemer = redeemer;
            this.Hunter = hunter;
            this.Warlord = warlord;
        }

        /// <summary>
        /// Gets or Sets Shaper
        /// </summary>
        [DataMember(Name = "shaper", IsRequired = true, EmitDefaultValue = false)]
        public bool Shaper { get; set; }

        /// <summary>
        /// Gets or Sets Elder
        /// </summary>
        [DataMember(Name = "elder", IsRequired = true, EmitDefaultValue = false)]
        public bool Elder { get; set; }

        /// <summary>
        /// Gets or Sets Crusader
        /// </summary>
        [DataMember(Name = "crusader", IsRequired = true, EmitDefaultValue = false)]
        public bool Crusader { get; set; }

        /// <summary>
        /// Gets or Sets Redeemer
        /// </summary>
        [DataMember(Name = "redeemer", IsRequired = true, EmitDefaultValue = false)]
        public bool Redeemer { get; set; }

        /// <summary>
        /// Gets or Sets Hunter
        /// </summary>
        [DataMember(Name = "hunter", IsRequired = true, EmitDefaultValue = false)]
        public bool Hunter { get; set; }

        /// <summary>
        /// Gets or Sets Warlord
        /// </summary>
        [DataMember(Name = "warlord", IsRequired = true, EmitDefaultValue = false)]
        public bool Warlord { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfluenceItemData {\n");
            sb.Append("  Shaper: ").Append(Shaper).Append("\n");
            sb.Append("  Elder: ").Append(Elder).Append("\n");
            sb.Append("  Crusader: ").Append(Crusader).Append("\n");
            sb.Append("  Redeemer: ").Append(Redeemer).Append("\n");
            sb.Append("  Hunter: ").Append(Hunter).Append("\n");
            sb.Append("  Warlord: ").Append(Warlord).Append("\n");
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
            return this.Equals(input as InfluenceItemData);
        }

        /// <summary>
        /// Returns true if InfluenceItemData instances are equal
        /// </summary>
        /// <param name="input">Instance of InfluenceItemData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfluenceItemData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Shaper == input.Shaper ||
                    this.Shaper.Equals(input.Shaper)
                ) && 
                (
                    this.Elder == input.Elder ||
                    this.Elder.Equals(input.Elder)
                ) && 
                (
                    this.Crusader == input.Crusader ||
                    this.Crusader.Equals(input.Crusader)
                ) && 
                (
                    this.Redeemer == input.Redeemer ||
                    this.Redeemer.Equals(input.Redeemer)
                ) && 
                (
                    this.Hunter == input.Hunter ||
                    this.Hunter.Equals(input.Hunter)
                ) && 
                (
                    this.Warlord == input.Warlord ||
                    this.Warlord.Equals(input.Warlord)
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
                hashCode = hashCode * 59 + this.Shaper.GetHashCode();
                hashCode = hashCode * 59 + this.Elder.GetHashCode();
                hashCode = hashCode * 59 + this.Crusader.GetHashCode();
                hashCode = hashCode * 59 + this.Redeemer.GetHashCode();
                hashCode = hashCode * 59 + this.Hunter.GetHashCode();
                hashCode = hashCode * 59 + this.Warlord.GetHashCode();
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
