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
    /// SkillDetailsInfo
    /// </summary>
    [DataContract(Name = "SkillDetailsInfo")]
    public partial class SkillDetailsInfo : IEquatable<SkillDetailsInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkillDetailsInfo" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="supportGems">supportGems.</param>
        /// <param name="dps">dps.</param>
        public SkillDetailsInfo(string name = default(string), StatInfoOfOverviewSkillMode supportGems = default(StatInfoOfOverviewSkillMode), Dictionary<string, List<long>> dps = default(Dictionary<string, List<long>>))
        {
            this.Name = name;
            this.SupportGems = supportGems;
            this.Dps = dps;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SupportGems
        /// </summary>
        [DataMember(Name = "supportGems", EmitDefaultValue = false)]
        public StatInfoOfOverviewSkillMode SupportGems { get; set; }

        /// <summary>
        /// Gets or Sets Dps
        /// </summary>
        [DataMember(Name = "dps", EmitDefaultValue = false)]
        public Dictionary<string, List<long>> Dps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SkillDetailsInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SupportGems: ").Append(SupportGems).Append("\n");
            sb.Append("  Dps: ").Append(Dps).Append("\n");
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
            return this.Equals(input as SkillDetailsInfo);
        }

        /// <summary>
        /// Returns true if SkillDetailsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SkillDetailsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SkillDetailsInfo input)
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
                    this.SupportGems == input.SupportGems ||
                    (this.SupportGems != null &&
                    this.SupportGems.Equals(input.SupportGems))
                ) &&
                (
                    this.Dps == input.Dps ||
                    this.Dps != null &&
                    input.Dps != null &&
                    this.Dps.SequenceEqual(input.Dps)
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
                if (this.SupportGems != null)
                    hashCode = hashCode * 59 + this.SupportGems.GetHashCode();
                if (this.Dps != null)
                    hashCode = hashCode * 59 + this.Dps.GetHashCode();
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
