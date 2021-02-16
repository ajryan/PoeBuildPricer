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
    /// SocketData
    /// </summary>
    [DataContract(Name = "SocketData")]
    public partial class SocketData : IEquatable<SocketData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SocketData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SocketData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SocketData" /> class.
        /// </summary>
        /// <param name="group">group (required).</param>
        /// <param name="attr">attr.</param>
        /// <param name="sColour">sColour.</param>
        public SocketData(int group = default(int), string attr = default(string), string sColour = default(string))
        {
            this.Group = group;
            this.Attr = attr;
            this.SColour = sColour;
        }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", IsRequired = true, EmitDefaultValue = false)]
        public int Group { get; set; }

        /// <summary>
        /// Gets or Sets Attr
        /// </summary>
        [DataMember(Name = "attr", EmitDefaultValue = false)]
        public string Attr { get; set; }

        /// <summary>
        /// Gets or Sets SColour
        /// </summary>
        [DataMember(Name = "sColour", EmitDefaultValue = false)]
        public string SColour { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SocketData {\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Attr: ").Append(Attr).Append("\n");
            sb.Append("  SColour: ").Append(SColour).Append("\n");
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
            return this.Equals(input as SocketData);
        }

        /// <summary>
        /// Returns true if SocketData instances are equal
        /// </summary>
        /// <param name="input">Instance of SocketData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocketData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Group == input.Group ||
                    this.Group.Equals(input.Group)
                ) && 
                (
                    this.Attr == input.Attr ||
                    (this.Attr != null &&
                    this.Attr.Equals(input.Attr))
                ) && 
                (
                    this.SColour == input.SColour ||
                    (this.SColour != null &&
                    this.SColour.Equals(input.SColour))
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
                hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Attr != null)
                    hashCode = hashCode * 59 + this.Attr.GetHashCode();
                if (this.SColour != null)
                    hashCode = hashCode * 59 + this.SColour.GetHashCode();
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
