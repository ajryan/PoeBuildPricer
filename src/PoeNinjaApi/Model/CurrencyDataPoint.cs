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
    /// CurrencyDataPoint
    /// </summary>
    [DataContract(Name = "CurrencyDataPoint")]
    public partial class CurrencyDataPoint : IEquatable<CurrencyDataPoint>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyDataPoint" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CurrencyDataPoint() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyDataPoint" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="leagueId">leagueId (required).</param>
        /// <param name="payCurrencyId">payCurrencyId (required).</param>
        /// <param name="getCurrencyId">getCurrencyId (required).</param>
        /// <param name="sampleTimeUtc">sampleTimeUtc (required).</param>
        /// <param name="count">count (required).</param>
        /// <param name="value">value (required).</param>
        /// <param name="dataPointCount">dataPointCount (required).</param>
        /// <param name="includesSecondary">includesSecondary (required).</param>
        /// <param name="listingCount">listingCount.</param>
        public CurrencyDataPoint(long id = default(long), int leagueId = default(int), int payCurrencyId = default(int), int getCurrencyId = default(int), DateTime sampleTimeUtc = default(DateTime), int count = default(int), decimal value = default(decimal), int dataPointCount = default(int), bool includesSecondary = default(bool), int listingCount = default(int))
        {
            this.Id = id;
            this.LeagueId = leagueId;
            this.PayCurrencyId = payCurrencyId;
            this.GetCurrencyId = getCurrencyId;
            this.SampleTimeUtc = sampleTimeUtc;
            this.Count = count;
            this.Value = value;
            this.DataPointCount = dataPointCount;
            this.IncludesSecondary = includesSecondary;
            this.ListingCount = listingCount;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets LeagueId
        /// </summary>
        [DataMember(Name = "league_id", IsRequired = true, EmitDefaultValue = false)]
        public int LeagueId { get; set; }

        /// <summary>
        /// Gets or Sets PayCurrencyId
        /// </summary>
        [DataMember(Name = "pay_currency_id", IsRequired = true, EmitDefaultValue = false)]
        public int PayCurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets GetCurrencyId
        /// </summary>
        [DataMember(Name = "get_currency_id", IsRequired = true, EmitDefaultValue = false)]
        public int GetCurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets SampleTimeUtc
        /// </summary>
        [DataMember(Name = "sample_time_utc", IsRequired = true, EmitDefaultValue = false)]
        public DateTime SampleTimeUtc { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", IsRequired = true, EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or Sets DataPointCount
        /// </summary>
        [DataMember(Name = "data_point_count", IsRequired = true, EmitDefaultValue = false)]
        public int DataPointCount { get; set; }

        /// <summary>
        /// Gets or Sets IncludesSecondary
        /// </summary>
        [DataMember(Name = "includes_secondary", IsRequired = true, EmitDefaultValue = false)]
        public bool IncludesSecondary { get; set; }

        /// <summary>
        /// Gets or Sets ListingCount
        /// </summary>
        [DataMember(Name = "listing_count", EmitDefaultValue = false)]
        public int ListingCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrencyDataPoint {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LeagueId: ").Append(LeagueId).Append("\n");
            sb.Append("  PayCurrencyId: ").Append(PayCurrencyId).Append("\n");
            sb.Append("  GetCurrencyId: ").Append(GetCurrencyId).Append("\n");
            sb.Append("  SampleTimeUtc: ").Append(SampleTimeUtc).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  DataPointCount: ").Append(DataPointCount).Append("\n");
            sb.Append("  IncludesSecondary: ").Append(IncludesSecondary).Append("\n");
            sb.Append("  ListingCount: ").Append(ListingCount).Append("\n");
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
            return this.Equals(input as CurrencyDataPoint);
        }

        /// <summary>
        /// Returns true if CurrencyDataPoint instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrencyDataPoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrencyDataPoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.LeagueId == input.LeagueId ||
                    this.LeagueId.Equals(input.LeagueId)
                ) && 
                (
                    this.PayCurrencyId == input.PayCurrencyId ||
                    this.PayCurrencyId.Equals(input.PayCurrencyId)
                ) && 
                (
                    this.GetCurrencyId == input.GetCurrencyId ||
                    this.GetCurrencyId.Equals(input.GetCurrencyId)
                ) && 
                (
                    this.SampleTimeUtc == input.SampleTimeUtc ||
                    (this.SampleTimeUtc != null &&
                    this.SampleTimeUtc.Equals(input.SampleTimeUtc))
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.DataPointCount == input.DataPointCount ||
                    this.DataPointCount.Equals(input.DataPointCount)
                ) && 
                (
                    this.IncludesSecondary == input.IncludesSecondary ||
                    this.IncludesSecondary.Equals(input.IncludesSecondary)
                ) && 
                (
                    this.ListingCount == input.ListingCount ||
                    this.ListingCount.Equals(input.ListingCount)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.LeagueId.GetHashCode();
                hashCode = hashCode * 59 + this.PayCurrencyId.GetHashCode();
                hashCode = hashCode * 59 + this.GetCurrencyId.GetHashCode();
                if (this.SampleTimeUtc != null)
                    hashCode = hashCode * 59 + this.SampleTimeUtc.GetHashCode();
                hashCode = hashCode * 59 + this.Count.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.DataPointCount.GetHashCode();
                hashCode = hashCode * 59 + this.IncludesSecondary.GetHashCode();
                hashCode = hashCode * 59 + this.ListingCount.GetHashCode();
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