using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PoeBuildPrice.Model;
using PoeNinjaApi.Model;

namespace PoeBuildPrice {
    public class Ninja {
        private static readonly string[] _itemTypes = new[] {
            "SkillGem",
            "UniqueJewel",
            "UniqueFlask",
            "UniqueWeapon",
            "UniqueArmour",
            "UniqueAccessory"
        };

        private readonly Dictionary<string, NinjaItemPrice> _pricesByDetailsId = new Dictionary<string, NinjaItemPrice>();

        public async Task Init() {
            Console.WriteLine("Init Ninja prices");
            foreach (var itemType in _itemTypes) {
                Console.WriteLine($"  {itemType}");
                var priceResponse = await new HttpClient().GetAsync(
                    $"https://poe.ninja/api/data/itemoverview?league=Ritual&type={itemType}");
                var priceContent = await priceResponse.Content.ReadAsStringAsync();
                var itemInfos = JsonConvert.DeserializeObject<NinjaItemPrices>(priceContent);

                foreach (var item in itemInfos.lines)
                {
                  _pricesByDetailsId.Add(item.detailsId, item);
                }
            }
        }

        public decimal? GetItemPrice(Rarity rarity, ItemData item) {
          var detailsId = GetDetailsId(rarity, item);

          if (_pricesByDetailsId.TryGetValue(detailsId, out var price)) {
            Console.WriteLine($"    ninja {detailsId} = {price.chaosValue}");
            return price.chaosValue;
          }

          Console.WriteLine($"    !!ninja {detailsId} not found");
          return null;
        }

        public string GetDetailsId(Rarity rarity, ItemData item) {
            return rarity == Rarity.Gem
                ? GetGemDetailsId(item)
                : GetUniqueDetailsId(item);
        }

        private static readonly string[] SPECIAL_SUPPORT_GEMS = new[] { "Empower Support", "Enlighten Support", "Enhance Support" };

        private static string GetGemDetailsId(ItemData gem) {
            if (gem.TypeLine == "Portal") {
                return "portal-1";
            }

            var id = NameToDetailsId(gem.TypeLine);

            if (SPECIAL_SUPPORT_GEMS.Contains(gem.TypeLine) ||
                gem.TypeLine == "Brand Recall" ||
                gem.TypeLine == "Blood and Sand" ||
                gem.TypeLine.StartsWith("Awakened") ||
                gem.Level >= 20) {
                id += $"-{gem.Level}";
            }
            else {
                id += "-1";
            }
            if (gem.Quality.HasValue && gem.Quality.Value >= 20) {
                int quality = gem.Quality.Value;
                if (!SPECIAL_SUPPORT_GEMS.Contains(gem.TypeLine) && !(gem.TypeLine == "Brand Recall" && gem.Corrupted)) {
                    int q = (quality >= 16 && quality <= 20) ? 20 : quality;
                    if (gem.TypeLine.StartsWith("Awakened") && q > 20) {
                      q = 20;
                    }
                    id += $"-{q}";
                }
            }

            if (gem.Corrupted) {
                id += "c";
            }

            return id;
        }

        private static string GetUniqueDetailsId(ItemData item) {
            if (item.TypeLine.Contains("flask", StringComparison.OrdinalIgnoreCase)) {
              return NameToDetailsId(item.Name);
            }

            string id = NameToDetailsId($"{item.Name}{GetUniqueVariant(item)} {item.TypeLine}");
            if (item.LinkedSocketCount >= 5) {
                id += $"-{item.LinkedSocketCount}l";
            }

            return id;
        }

        private static string GetUniqueVariant(ItemData item) {
            bool hasStat(ItemData item, string stat) {
                return item.Mods.Any(m => m == stat);
            }

            if (item.Name == "Vessel of Vinktar") {
                if (hasStat(item, "Adds # to # Lightning Damage to Attacks during Flask effect")) {
                    return "-added-attacks";
                }
                else if (hasStat(item, "Adds # to # Lightning Damage to Spells during Flask effect")) {
                    return "-added-spells";
                }
                else if (hasStat(item, "Damage Penetrates #% Lightning Resistance during Flask effect")) {
                    return "-penetration";
                }
                else if (hasStat(item, "#% of Physical Damage Converted to Lightning during Flask effect")) {
                    return "-conversion";
                }
            }
            else if (item.Name == "Atziri's Splendour") {
                if (hasStat(item, "#% increased Armour, Evasion and Energy Shield")) {
                    return "-armour-evasion-es";
                }
                else if (hasStat(item, "#% increased Evasion and Energy Shield") && hasStat(item, "+# to maximum Energy Shield")) {
                    return "-evasion-es";
                }
                else if (hasStat(item, "#% increased Evasion and Energy Shield") && hasStat(item, "+# to maximum Life")) {
                    return "-evasion-es-life";
                }
                else if (hasStat(item, "#% increased Armour and Energy Shield") && hasStat(item, "+# to maximum Energy Shield")) {
                    return "-armour-es";
                }
                else if (hasStat(item, "#% increased Armour and Energy Shield") && hasStat(item, "+# to maximum Life")) {
                    return "-armour-es-life";
                }
                else if (hasStat(item, "#% increased Armour and Evasion") && hasStat(item, "+# to maximum Life")) {
                    return "-armour-evasion";
                }
                else if (hasStat(item, "+# to maximum Energy Shield") && hasStat(item, "#% increased Energy Shield")) {
                    return "-es";
                }
                else if (hasStat(item, "#% increased Evasion Rating") && hasStat(item, "+# to maximum Life")) {
                    return "-evasion";
                }
                else if (hasStat(item, "#% increased Armour") && hasStat(item, "+# to maximum Life")) {
                    return "-armour";
                }
            }
            else if (item.Name == "Bubonic Trail" || item.Name == "Lightpoacher" || item.Name == "Shroud of the Lightless" || item.Name == "Tombfist") {
                  return "-2-jewels";
            }
            else if (item.Name == "Volkuur's Guidance") {
                if (hasStat(item, "Adds # to # Cold Damage to Spells and Attacks")) {
                    return "-cold";
                }
                else if (hasStat(item, "Adds # to # Fire Damage to Spells and Attacks")) {
                    return "-fire";
                }
                else if (hasStat(item, "Adds # to # Lightning Damage to Spells and Attacks")) {
                    return "-lightning";
                }
            }
            else if (item.Name == "Yriel's Fostering") {
                if (hasStat(item, "Projectiles from Attacks have #% chance to Maim on Hit while\nyou have a Bestial Minion")) {
                    return "-maim";
                }
                else if (hasStat(item, "Projectiles from Attacks have #% chance to Poison on Hit while\nyou have a Bestial Minion")) {
                    return "-poison";
                }
                else if (hasStat(item, "Projectiles from Attacks have #% chance to inflict Bleeding on Hit while\nyou have a Bestial Minion")) {
                    return "-bleeding";
                }
            }
            else if (item.Name == "Doryani's Invitation") {
                if (hasStat(item, "#% increased Global Physical Damage")) {
                    return "-physical";
                }
                else if (hasStat(item, "#% increased Fire Damage")) {
                    return "-fire";
                }
                else if (hasStat(item, "#% increased Cold Damage")) {
                    return "-cold";
                }
                else if (hasStat(item, "#% increased Lightning Damage")) {
                    return "-lightning";
                }
            }
            else if (item.Name == "Impresence") {
                if (hasStat(item, "Adds # to # Cold Damage")) {
                    return "-cold";
                }
                else if (hasStat(item, "Adds # to # Chaos Damage")) {
                    return "-chaos";
                }
                else if (hasStat(item, "Adds # to # Fire Damage")) {
                    return "-fire";
                }
                else if (hasStat(item, "Adds # to # Lightning Damage")) {
                    return "-lightning";
                }
                else if (hasStat(item, "Adds # to # Physical Damage")) {
                    return "-physical";
                }
            }

            return null;
        }

        private static string NameToDetailsId(string name) {
            return name?
                .ToLowerInvariant()
                .Replace(" ", "-")
                .Replace("|", "")
                .Replace("'", "");
        }
    }

    public class NinjaItemPrices {
        public NinjaItemPrice[] lines { get; set; }
    }

    public class NinjaItemPrice {
        public string id { get; set; }
        public string name { get; set; }
        public int itemClass { get; set; }
        public int gemLevel { get; set; }
        public int gemQuality { get; set; }
        public string itemType { get; set; }
        public decimal chaosValue { get; set; }
        public string detailsId { get; set; }
    }
}