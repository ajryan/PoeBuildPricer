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
    /// ItemData
    /// </summary>
    [DataContract(Name = "ItemData")]
    public partial class ItemData : IEquatable<ItemData>, IValidatableObject
    {
        /// <summary>
        /// Item is verified
        /// </summary>
        [DataMember(Name = "verified", EmitDefaultValue = true)]
        public bool Verified { get; set; }

        /// <summary>
        /// Gets or Sets FrameType
        /// </summary>
        [DataMember(Name = "frameType", IsRequired = true, EmitDefaultValue = false)]
        public ItemClass FrameType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemData" /> class.
        /// </summary>
        /// <param name="inventoryId">inventoryId.</param>
        /// <param name="name">name.</param>
        /// <param name="ilvl">ilvl (required).</param>
        /// <param name="icon">icon.</param>
        /// <param name="typeLine">typeLine.</param>
        /// <param name="implicitMods">implicitMods.</param>
        /// <param name="explicitMods">explicitss.</param>
        /// <param name="fracturedMods">fracturedMods.</param>
        /// <param name="craftedMods">craftedMods.</param>
        /// <param name="enchantMods">enchantMods.</param>
        /// <param name="properties">properties.</param>
        /// <param name="requirements">requirements.</param>
        /// <param name="sockets">sockets.</param>
        /// <param name="socketedItems">socketedItems.</param>
        /// <param name="hybrid">hybrid.</param>
        /// <param name="id">id.</param>
        /// <param name="identified">identified (required).</param>
        /// <param name="corrupted">corrupted (required).</param>
        /// <param name="fractured">fractured (required).</param>
        /// <param name="synthesised">synthesised (required).</param>
        /// <param name="w">w.</param>
        /// <param name="h">h.</param>
        /// <param name="x">x (required).</param>
        /// <param name="y">y (required).</param>
        /// <param name="note">note.</param>
        /// <param name="extended">extended.</param>
        /// <param name="league">league.</param>
        /// <param name="artFilename">artFilename.</param>
        /// <param name="flavourText">flavourText.</param>
        /// <param name="descrText">descrText.</param>
        /// <param name="prophecyText">prophecyText.</param>
        /// <param name="frameType">frameType (required).</param>
        /// <param name="replica">replica (required).</param>
        /// <param name="influences">influences.</param>
        public ItemData(string inventoryId = default(string), string name = default(string), int ilvl = default(int), string icon = default(string), string typeLine = default(string), List<string> implicitMods = default(List<string>), List<string> explicitMods = default(List<string>), List<string> fracturedMods = default(List<string>), List<string> craftedMods = default(List<string>), List<string> enchantMods = default(List<string>), List<PropertyData> properties = default(List<PropertyData>), List<PropertyData> requirements = default(List<PropertyData>), List<SocketData> sockets = default(List<SocketData>), List<SocketedItemData> socketedItems = default(List<SocketedItemData>), HybridGemData hybrid = default(HybridGemData), string id = default(string), bool identified = default(bool), bool corrupted = default(bool), bool fractured = default(bool), bool synthesised = default(bool), int w = default(int), int h = default(int), int x = default(int), int y = default(int), string note = default(string), ExtendedItemData extended = default(ExtendedItemData), string league = default(string), string artFilename = default(string), List<string> flavourText = default(List<string>), string descrText = default(string), string prophecyText = default(string), ItemClass frameType = default(ItemClass), bool replica = default(bool), InfluenceItemData influences = default(InfluenceItemData))
        {
            this.Ilvl = ilvl;
            this.Identified = identified;
            this.Corrupted = corrupted;
            this.Fractured = fractured;
            this.Synthesised = synthesised;
            this.X = x;
            this.Y = y;
            this.FrameType = frameType;
            this.Replica = replica;
            this.InventoryId = inventoryId;
            this.Name = name;
            this.Icon = icon;
            this.TypeLine = typeLine;
            this.ImplicitMods = implicitMods;
            this.ExplicitMods = explicitMods;
            this.FracturedMods = fracturedMods;
            this.CraftedMods = craftedMods;
            this.EnchantMods = enchantMods;
            this.Properties = properties;
            this.Requirements = requirements;
            this.Sockets = sockets;
            this.SocketedItems = socketedItems;
            this.Hybrid = hybrid;
            this.Id = id;
            this.W = w;
            this.H = h;
            this.Note = note;
            this.Extended = extended;
            this.League = league;
            this.ArtFilename = artFilename;
            this.FlavourText = flavourText;
            this.DescrText = descrText;
            this.ProphecyText = prophecyText;
            this.Influences = influences;
        }

        /// <summary>
        /// Gets or Sets InventoryId
        /// </summary>
        [DataMember(Name = "inventoryId", EmitDefaultValue = false)]
        public string InventoryId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Ilvl
        /// </summary>
        [DataMember(Name = "ilvl", IsRequired = true, EmitDefaultValue = false)]
        public int Ilvl { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or Sets TypeLine
        /// </summary>
        [DataMember(Name = "typeLine", EmitDefaultValue = false)]
        public string TypeLine { get; set; }

        /// <summary>
        /// Gets or Sets ImplicitMods
        /// </summary>
        [DataMember(Name = "implicitMods", EmitDefaultValue = false)]
        public List<string> ImplicitMods { get; set; }

        /// <summary>
        /// Gets or Sets ExplicitMods
        /// </summary>
        [DataMember(Name = "explicitMods", EmitDefaultValue = false)]
        public List<string> ExplicitMods { get; set; }

        /// <summary>
        /// Gets or Sets FracturedMods
        /// </summary>
        [DataMember(Name = "fracturedMods", EmitDefaultValue = false)]
        public List<string> FracturedMods { get; set; }

        /// <summary>
        /// Gets or Sets CraftedMods
        /// </summary>
        [DataMember(Name = "craftedMods", EmitDefaultValue = false)]
        public List<string> CraftedMods { get; set; }

        /// <summary>
        /// Gets or Sets EnchantMods
        /// </summary>
        [DataMember(Name = "enchantMods", EmitDefaultValue = false)]
        public List<string> EnchantMods { get; set; }

        private List<string> _mods;
        public List<string> Mods {
            get {
                return _mods ?? (_mods = ParseMods());
            }
        }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public List<PropertyData> Properties { get; set; }

        /// <summary>
        /// Calculated alternate quality
        /// </summary>
        public int? AlternateQuality {
            get {
                List<String> altQuality = Properties?
                    .SelectMany(p => p.Values)
                    .FirstOrDefault(v => v[0] == "Alternate Quality");
                return altQuality == null
                    ? (int?)null
                    : Int32.Parse(altQuality[1]);
            }
        }

        private static readonly Regex _digitsRegex = new Regex(@"\+?(\d+).*", RegexOptions.Compiled);

        /// <summary>item or gem level</summary>
        public int? Level {
            get {
                return ParseProperty("Level");
            }
        }

        /// <summary>quality</summary>
        public int? Quality {
            get {
                return ParseProperty("Quality");
            }
        }

        private int? ParseProperty(string propertyName) {
            String propertyString = Properties?.FirstOrDefault(p => p.Name == propertyName)?.Values?[0]?[0];
                return propertyString == null
                    ? (int?)null
                    : Int32.Parse(_digitsRegex.Match(propertyString).Groups[1].Value);
        }

        /// <summary>
        /// Gets or Sets Requirements
        /// </summary>
        [DataMember(Name = "requirements", EmitDefaultValue = false)]
        public List<PropertyData> Requirements { get; set; }

        /// <summary>
        /// Gets or Sets Sockets
        /// </summary>
        [DataMember(Name = "sockets", EmitDefaultValue = false)]
        public List<SocketData> Sockets { get; set; }

        /// <summary>Count of linked sockets (biggest if multiple groups)</summary>
        public int LinkedSocketCount {
            get {
                var socketGroupCounts = Sockets?.GroupBy(s => s.Group).Select(g => g.Count());
                return socketGroupCounts?.Any() == true ? socketGroupCounts.Max() : 0;
            }
        }

        /// <summary>
        /// Gets or Sets SocketedItems
        /// </summary>
        [DataMember(Name = "socketedItems", EmitDefaultValue = false)]
        public List<SocketedItemData> SocketedItems { get; set; }

        /// <summary>
        /// Gets or Sets Hybrid
        /// </summary>
        [DataMember(Name = "hybrid", EmitDefaultValue = false)]
        public HybridGemData Hybrid { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Identified
        /// </summary>
        [DataMember(Name = "identified", IsRequired = true, EmitDefaultValue = false)]
        public bool Identified { get; set; }

        /// <summary>
        /// Gets or Sets Corrupted
        /// </summary>
        [DataMember(Name = "corrupted", IsRequired = true, EmitDefaultValue = false)]
        public bool Corrupted { get; set; }

        /// <summary>
        /// Gets or Sets Fractured
        /// </summary>
        [DataMember(Name = "fractured", IsRequired = true, EmitDefaultValue = false)]
        public bool Fractured { get; set; }

        /// <summary>
        /// Gets or Sets Synthesised
        /// </summary>
        [DataMember(Name = "synthesised", IsRequired = true, EmitDefaultValue = false)]
        public bool Synthesised { get; set; }

        /// <summary>
        /// Gets or Sets W
        /// </summary>
        [DataMember(Name = "w", EmitDefaultValue = false)]
        public int W { get; set; }

        /// <summary>
        /// Gets or Sets H
        /// </summary>
        [DataMember(Name = "h", EmitDefaultValue = false)]
        public int H { get; set; }

        /// <summary>
        /// Gets or Sets X
        /// </summary>
        [DataMember(Name = "x", IsRequired = true, EmitDefaultValue = true)]
        public int X { get; set; }

        /// <summary>
        /// Gets or Sets Y
        /// </summary>
        [DataMember(Name = "y", IsRequired = true, EmitDefaultValue = true)]
        public int Y { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets Extended
        /// </summary>
        [DataMember(Name = "extended", EmitDefaultValue = false)]
        public ExtendedItemData Extended { get; set; }

        /// <summary>
        /// Gets or Sets League
        /// </summary>
        [DataMember(Name = "league", EmitDefaultValue = false)]
        public string League { get; set; }

        /// <summary>
        /// Gets or Sets ArtFilename
        /// </summary>
        [DataMember(Name = "artFilename", EmitDefaultValue = false)]
        public string ArtFilename { get; set; }

        /// <summary>
        /// Gets or Sets FlavourText
        /// </summary>
        [DataMember(Name = "flavourText", EmitDefaultValue = false)]
        public List<string> FlavourText { get; set; }

        /// <summary>
        /// Gets or Sets DescrText
        /// </summary>
        [DataMember(Name = "descrText", EmitDefaultValue = false)]
        public string DescrText { get; set; }

        /// <summary>
        /// Gets or Sets ProphecyText
        /// </summary>
        [DataMember(Name = "prophecyText", EmitDefaultValue = false)]
        public string ProphecyText { get; set; }

        /// <summary>
        /// Gets or Sets Replica
        /// </summary>
        [DataMember(Name = "replica", IsRequired = true, EmitDefaultValue = false)]
        public bool Replica { get; set; }

        /// <summary>
        /// Gets or Sets Influences
        /// </summary>
        [DataMember(Name = "influences", EmitDefaultValue = false)]
        public InfluenceItemData Influences { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemData {\n");
            sb.Append("  InventoryId: ").Append(InventoryId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ilvl: ").Append(Ilvl).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  TypeLine: ").Append(TypeLine).Append("\n");
            sb.Append("  ImplicitMods: ").Append(ImplicitMods).Append("\n");
            sb.Append("  ExplicitMods: ").Append(ExplicitMods).Append("\n");
            sb.Append("  FracturedMods: ").Append(FracturedMods).Append("\n");
            sb.Append("  CraftedMods: ").Append(CraftedMods).Append("\n");
            sb.Append("  EnchantMods: ").Append(EnchantMods).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Requirements: ").Append(Requirements).Append("\n");
            sb.Append("  Sockets: ").Append(Sockets).Append("\n");
            sb.Append("  SocketedItems: ").Append(SocketedItems).Append("\n");
            sb.Append("  Hybrid: ").Append(Hybrid).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Identified: ").Append(Identified).Append("\n");
            sb.Append("  Corrupted: ").Append(Corrupted).Append("\n");
            sb.Append("  Fractured: ").Append(Fractured).Append("\n");
            sb.Append("  Synthesised: ").Append(Synthesised).Append("\n");
            sb.Append("  W: ").Append(W).Append("\n");
            sb.Append("  H: ").Append(H).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Extended: ").Append(Extended).Append("\n");
            sb.Append("  League: ").Append(League).Append("\n");
            sb.Append("  ArtFilename: ").Append(ArtFilename).Append("\n");
            sb.Append("  FlavourText: ").Append(FlavourText).Append("\n");
            sb.Append("  DescrText: ").Append(DescrText).Append("\n");
            sb.Append("  ProphecyText: ").Append(ProphecyText).Append("\n");
            sb.Append("  FrameType: ").Append(FrameType).Append("\n");
            sb.Append("  Replica: ").Append(Replica).Append("\n");
            sb.Append("  Influences: ").Append(Influences).Append("\n");
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
            return this.Equals(input as ItemData);
        }

        /// <summary>
        /// Returns true if ItemData instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemData input)
        {
            if (input == null)
                return false;

            return
                (
                    this.InventoryId == input.InventoryId ||
                    (this.InventoryId != null &&
                    this.InventoryId.Equals(input.InventoryId))
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.Ilvl == input.Ilvl ||
                    this.Ilvl.Equals(input.Ilvl)
                ) &&
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) &&
                (
                    this.TypeLine == input.TypeLine ||
                    (this.TypeLine != null &&
                    this.TypeLine.Equals(input.TypeLine))
                ) &&
                (
                    this.ImplicitMods == input.ImplicitMods ||
                    this.ImplicitMods != null &&
                    input.ImplicitMods != null &&
                    this.ImplicitMods.SequenceEqual(input.ImplicitMods)
                ) &&
                (
                    this.ExplicitMods == input.ExplicitMods ||
                    this.ExplicitMods != null &&
                    input.ExplicitMods != null &&
                    this.ExplicitMods.SequenceEqual(input.ExplicitMods)
                ) &&
                (
                    this.FracturedMods == input.FracturedMods ||
                    this.FracturedMods != null &&
                    input.FracturedMods != null &&
                    this.FracturedMods.SequenceEqual(input.FracturedMods)
                ) &&
                (
                    this.CraftedMods == input.CraftedMods ||
                    this.CraftedMods != null &&
                    input.CraftedMods != null &&
                    this.CraftedMods.SequenceEqual(input.CraftedMods)
                ) &&
                (
                    this.EnchantMods == input.EnchantMods ||
                    this.EnchantMods != null &&
                    input.EnchantMods != null &&
                    this.EnchantMods.SequenceEqual(input.EnchantMods)
                ) &&
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) &&
                (
                    this.Requirements == input.Requirements ||
                    this.Requirements != null &&
                    input.Requirements != null &&
                    this.Requirements.SequenceEqual(input.Requirements)
                ) &&
                (
                    this.Sockets == input.Sockets ||
                    this.Sockets != null &&
                    input.Sockets != null &&
                    this.Sockets.SequenceEqual(input.Sockets)
                ) &&
                (
                    this.SocketedItems == input.SocketedItems ||
                    this.SocketedItems != null &&
                    input.SocketedItems != null &&
                    this.SocketedItems.SequenceEqual(input.SocketedItems)
                ) &&
                (
                    this.Hybrid == input.Hybrid ||
                    (this.Hybrid != null &&
                    this.Hybrid.Equals(input.Hybrid))
                ) &&
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) &&
                (
                    this.Identified == input.Identified ||
                    this.Identified.Equals(input.Identified)
                ) &&
                (
                    this.Corrupted == input.Corrupted ||
                    this.Corrupted.Equals(input.Corrupted)
                ) &&
                (
                    this.Fractured == input.Fractured ||
                    this.Fractured.Equals(input.Fractured)
                ) &&
                (
                    this.Synthesised == input.Synthesised ||
                    this.Synthesised.Equals(input.Synthesised)
                ) &&
                (
                    this.W == input.W
                ) &&
                (
                    this.H == input.H
                ) &&
                (
                    this.X == input.X
                ) &&
                (
                    this.Y == input.Y
                ) &&
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) &&
                (
                    this.Extended == input.Extended ||
                    (this.Extended != null &&
                    this.Extended.Equals(input.Extended))
                ) &&
                (
                    this.League == input.League ||
                    (this.League != null &&
                    this.League.Equals(input.League))
                ) &&
                (
                    this.ArtFilename == input.ArtFilename ||
                    (this.ArtFilename != null &&
                    this.ArtFilename.Equals(input.ArtFilename))
                ) &&
                (
                    this.FlavourText == input.FlavourText ||
                    this.FlavourText != null &&
                    input.FlavourText != null &&
                    this.FlavourText.SequenceEqual(input.FlavourText)
                ) &&
                (
                    this.DescrText == input.DescrText ||
                    (this.DescrText != null &&
                    this.DescrText.Equals(input.DescrText))
                ) &&
                (
                    this.ProphecyText == input.ProphecyText ||
                    (this.ProphecyText != null &&
                    this.ProphecyText.Equals(input.ProphecyText))
                ) &&
                (
                    this.FrameType == input.FrameType ||
                    this.FrameType.Equals(input.FrameType)
                ) &&
                (
                    this.Replica == input.Replica ||
                    this.Replica.Equals(input.Replica)
                ) &&
                (
                    this.Influences == input.Influences ||
                    (this.Influences != null &&
                    this.Influences.Equals(input.Influences))
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
                if (this.InventoryId != null)
                    hashCode = hashCode * 59 + this.InventoryId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Ilvl.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.TypeLine != null)
                    hashCode = hashCode * 59 + this.TypeLine.GetHashCode();
                if (this.ImplicitMods != null)
                    hashCode = hashCode * 59 + this.ImplicitMods.GetHashCode();
                if (this.ExplicitMods != null)
                    hashCode = hashCode * 59 + this.ExplicitMods.GetHashCode();
                if (this.FracturedMods != null)
                    hashCode = hashCode * 59 + this.FracturedMods.GetHashCode();
                if (this.CraftedMods != null)
                    hashCode = hashCode * 59 + this.CraftedMods.GetHashCode();
                if (this.EnchantMods != null)
                    hashCode = hashCode * 59 + this.EnchantMods.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Requirements != null)
                    hashCode = hashCode * 59 + this.Requirements.GetHashCode();
                if (this.Sockets != null)
                    hashCode = hashCode * 59 + this.Sockets.GetHashCode();
                if (this.SocketedItems != null)
                    hashCode = hashCode * 59 + this.SocketedItems.GetHashCode();
                if (this.Hybrid != null)
                    hashCode = hashCode * 59 + this.Hybrid.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.Identified.GetHashCode();
                hashCode = hashCode * 59 + this.Corrupted.GetHashCode();
                hashCode = hashCode * 59 + this.Fractured.GetHashCode();
                hashCode = hashCode * 59 + this.Synthesised.GetHashCode();
                hashCode = hashCode * 59 + this.W.GetHashCode();
                hashCode = hashCode * 59 + this.H.GetHashCode();
                hashCode = hashCode * 59 + this.X.GetHashCode();
                hashCode = hashCode * 59 + this.Y.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.Extended != null)
                    hashCode = hashCode * 59 + this.Extended.GetHashCode();
                if (this.League != null)
                    hashCode = hashCode * 59 + this.League.GetHashCode();
                if (this.ArtFilename != null)
                    hashCode = hashCode * 59 + this.ArtFilename.GetHashCode();
                if (this.FlavourText != null)
                    hashCode = hashCode * 59 + this.FlavourText.GetHashCode();
                if (this.DescrText != null)
                    hashCode = hashCode * 59 + this.DescrText.GetHashCode();
                if (this.ProphecyText != null)
                    hashCode = hashCode * 59 + this.ProphecyText.GetHashCode();
                hashCode = hashCode * 59 + this.FrameType.GetHashCode();
                hashCode = hashCode * 59 + this.Replica.GetHashCode();
                if (this.Influences != null)
                    hashCode = hashCode * 59 + this.Influences.GetHashCode();
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

        private List<string> ParseMods() {
            return StatParser.ParseModifiersFromStats(this);
        }
    }

}
