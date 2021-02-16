using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PoeBuildPrice.Model;
using PoeNinjaApi.Api;
using PoeNinjaApi.Model;

namespace PoeBuildPrice {
    class Program {
        static async Task<int> Main() {
            var dataApi = new DataApi(new PoeNinjaApi.Client.Configuration {
                BasePath = "https://poe.ninja"
            });
            var ninja = new Ninja();
            await ninja.Init();

            var response = dataApi.DataGetBuildOverviewWithHttpInfo(
                Guid.NewGuid().ToString(),
                overview: "ritual",
                type: 0,
                language: "en");

            System.IO.File.WriteAllText("/Users/aidanrya/Desktop/b.json", response.RawContent);
            var overview = JsonConvert.DeserializeObject<OverviewSnapshot>(response.RawContent);

            var dpsScores = overview.SkillDetails
                .Where(sd => sd.Name == "Vortex")
                .SelectMany(
                    sd => sd.Dps.Select(dps => new { sd.Name, AccountIndex = Int32.Parse(dps.Key), Dps = dps.Value[0] }))
                .OrderByDescending(dpsScore => dpsScore.Dps);

            var characterPrices = new List<CharacterPrice>();
            int charNumber = 1;
            foreach (var dpsScore in dpsScores.Take(50)) {
                var account = overview.Accounts[dpsScore.AccountIndex];
                var character = overview.Names[dpsScore.AccountIndex];

                Console.WriteLine($"price {character}");
                var price = await PriceCharacter(dataApi, ninja, overview, dpsScore.AccountIndex);
                var cp = new CharacterPrice(character, account, dpsScore.Name, dpsScore.Dps, price);
                characterPrices.Add(cp);
                Console.WriteLine($"{charNumber++}/{50} - {cp.Character} ({cp.Account}): {cp.Skill} -> {cp.Dps:n} / {cp.Price:0,0}: {cp.DpsPerChaos:0,0} dps per c");
                Console.WriteLine();
            }

            var bestValue = characterPrices.OrderByDescending(cp => cp.DpsPerChaos).First();
            Console.WriteLine($"BEST: {bestValue.Character} ({bestValue.Account}): {bestValue.Skill} -> {bestValue.Dps:n} / {bestValue.Price:0,0}: {bestValue.DpsPerChaos:0,0} dps per c");

            return 0;
        }

        private static async Task<decimal> PriceCharacter(DataApi api, Ninja ninja, OverviewSnapshot overview, int index) {
            var character = api.DataGetCharacterWithHttpInfo(
                Guid.NewGuid().ToString(),
                account: overview.Accounts[index],
                name: overview.Names[index],
                overview: "ritual",
                type: 0,
                language: "en");

            var totalPrice = 0m;
            Console.WriteLine("items...");
            foreach (var item in character.Data.Items) {
                var price = await PriceItem(ninja, item);
                totalPrice += price;
                Console.WriteLine($"  {item.ItemData.Name} {item.ItemData.TypeLine}: {price}");
            }

            Console.WriteLine("flasks...");
            foreach (var flask in character.Data.Flasks) {
                var price = await PriceItem(ninja, flask);
                totalPrice += price;
                Console.WriteLine($"  {flask.ItemData.Name} {flask.ItemData.TypeLine}: {price}");
            }

            Console.WriteLine("jewels...");
            foreach (var jewel in character.Data.Jewels) {
                var price = await PriceItem(ninja, jewel);
                totalPrice += price;
                Console.WriteLine($"  {jewel.ItemData.Name} {jewel.ItemData.TypeLine}: {price}");
            }

            Console.WriteLine("gems...");
            foreach (var gem in character.Data.Items.SelectMany(item => item.ItemData.SocketedItems)) {
                var price = PriceGem(ninja, gem);
                totalPrice += price;
                Console.WriteLine($"  {gem.TypeLine}: {price}");
            }
            Console.WriteLine();

            return totalPrice;
        }

        private static Task<decimal> PriceItem(Ninja ninja, ItemModel item) {
            var rarity = (Rarity)item.ItemClass;
            if (rarity == Rarity.Unique && item.ItemData.Name != "Watcher's Eye") {
                var ninjaPrice = ninja.GetItemPrice(rarity, item.ItemData);
                if (ninjaPrice.HasValue) {
                    return Task.FromResult(ninjaPrice.Value);
                }
            }

            var dump = DumpItem(item);
            return PriceDump(dump);
        }

        private static decimal PriceGem(Ninja ninja, ItemData gem) {
            var ninjaPrice = ninja.GetItemPrice(Rarity.Gem, gem);
            if (ninjaPrice.HasValue) {
                return ninjaPrice.Value;
            }
            return 10m;
        }

        private static async Task<decimal> PriceDump(string dump) {
            try {
                var base64ItemText = Convert.ToBase64String(Encoding.UTF8.GetBytes(dump));
                var url = $"https://www.poeprices.info/api?i={base64ItemText}&l=Ritual";
                var response = await new HttpClient().GetAsync(url);
                if (!response.IsSuccessStatusCode) {
                    Console.WriteLine($"Can't price item: {response.StatusCode}");
                    return 0m;
                }
                var content = await response.Content.ReadAsStringAsync();
                var price = JsonConvert.DeserializeObject<PoePriceInfo>(content);

                return price.AvgPriceInChaos;
            }
            catch {
                return 0m;
            }
        }

        private const string DIV_LINE = "--------";

        private static string DumpItem(ItemModel item) {
            var sb = new StringBuilder();
            sb.AppendLine($"Rarity: {((Rarity)item.ItemClass):g}");
            sb.AppendLine(item.ItemData.Name);
            sb.AppendLine(item.ItemData.TypeLine);
            sb.AppendLine(DIV_LINE);

            if (item.ItemData.Properties?.Count > 0) {
                item.ItemData.Properties.ForEach(p => {
                    var qualityValue = p.Values?.FirstOrDefault()?.FirstOrDefault();
                    if (qualityValue != null) sb.AppendLine($"{p.Name}: {qualityValue}");
                });
                sb.AppendLine(DIV_LINE);
            }

            var levelRequired = item.ItemData.Requirements?[0]?.Values?[0]?[0];
            if (levelRequired != null) {
                sb.AppendLine("Requirements:");
                sb.AppendLine($"Level: {levelRequired}");
                sb.AppendLine(DIV_LINE);
            }

            if (item.ItemData.Sockets?.Count > 0) {
                sb.Append($"Sockets: ");
                item.ItemData.Sockets.GroupBy(s => s.Group).ToList().ForEach(socketGroup => {
                    sb.Append(String.Join("-", socketGroup.Select(sd => sd.SColour)));
                    sb.Append(' ');
                });
                sb.AppendLine();
                sb.AppendLine(DIV_LINE);
            }

            sb.AppendLine($"Item Level: {item.ItemData.Ilvl}");
            sb.AppendLine(DIV_LINE);

            if (item.ItemData.EnchantMods?.Count > 0) {
                item.ItemData.EnchantMods.ForEach(ench =>
                    sb.AppendLine($"{ench} (enchant)")
                );
                sb.AppendLine(DIV_LINE);
            }

            if (item.ItemData.ImplicitMods?.Count > 0) {
                item.ItemData.ImplicitMods.ForEach(impl =>
                    sb.AppendLine($"{impl} (implicit)")
                );
                sb.AppendLine(DIV_LINE);
            }

            if (item.ItemData.ExplicitMods?.Count > 0) {
                item.ItemData.ExplicitMods.Where(expl => !expl.Contains("also grant")).ToList().ForEach(expl =>
                    sb.AppendLine(expl)
                );
                sb.AppendLine(DIV_LINE);
            }

            if (item.ItemData.Influences?.Crusader == true) sb.AppendLine("Crusader Item");
            if (item.ItemData.Influences?.Elder == true) sb.AppendLine("Elder Item");
            if (item.ItemData.Influences?.Hunter == true) sb.AppendLine("Hunter Item");
            if (item.ItemData.Influences?.Redeemer == true) sb.AppendLine("Redeemer Item");
            if (item.ItemData.Influences?.Shaper == true) sb.AppendLine("Shaper Item");
            if (item.ItemData.Influences?.Warlord == true) sb.AppendLine("Warlord Item");

            if (item.ItemData.TypeLine.Contains("Cluster")) {
                sb.AppendLine("Place into an allocated Medium or Large Jewel Socket on the Passive Skill Tree. Added passives do not interact with jewel radiuses. Right click to remove from the Socket.");
                sb.AppendLine(DIV_LINE);
            }

            if (item.ItemData.Corrupted) {
                sb.AppendLine("Corrupted");
            }

            return sb.ToString();
        }

        private static string DumpGem(ItemData gem) {
            var sb = new StringBuilder();
            sb.AppendLine("Rarity: Gem");
            sb.AppendLine(gem.TypeLine);
            sb.AppendLine(DIV_LINE);

            sb.AppendLine($"Level: {gem.Level}");
            sb.AppendLine($"Quality: +{gem.Quality}%");
            sb.AppendLine(DIV_LINE);

            if (gem.Corrupted) {
                sb.AppendLine("Corrupted");
            }

            return sb.ToString();
        }
    }
}

/* CLUSTE

Rarity: Rare
Viper Hope
Medium Cluster Jewel
--------
Requirements:
Level: 40
--------
Item Level: 82
--------
Adds 6 Passive Skills (enchant)
1 Added Passive Skill is a Jewel Socket (enchant)
Added Small Passive Skills grant: 3% increased effect of Non-Curse Auras from your Skills (enchant)
--------
Damage Penetrates 1% Elemental Resistances (implicit)
--------
Added Small Passive Skills also grant: 4% increased Mana Regeneration Rate
1 Added Passive Skill is Self-Control
1 Added Passive Skill is First Among Equals
--------
Place into an allocated Medium or Large Jewel Socket on the Passive Skill Tree. Added passives do not interact with jewel radiuses. Right click to remove from the Socket.
--------
Corrupted
--------
Note: ~price 20 chaos

*/


/*

Rarity: Rare
Blood Ward
Astral Plate
--------
Quality: +30% (augmented)
Armour: 924 (augmented)
--------
Requirements:
Level: 64
Str: 180
--------
Sockets: W-W-W-W-W-W
--------
Item Level: 100
--------
+12% to all Elemental Resistances (implicit)
Item sells for much more to vendors (implicit)
--------
+1 to Level of Socketed Strength Gems
+1 to Level of Socketed Intelligence Gems
+1 to Level of Socketed Support Gems
+1 to Level of Socketed Active Skill Gems
+45 to Strength
+85 to maximum Life (crafted)
--------
Elder Item
Warlord Item
--------
Note: ~price 250 exalted


*/

/*
Rarity: Gem
Combustion Support
--------
Fire, Support
Level: 20 (Max)
Mana Multiplier: 120%
Quality: +20% (augmented)
--------
Requirements:
Level: 70
Int: 111
--------
Supports any skill that hits enemies.
--------
Supported Skills deal 29% more Fire Damage
Supported Skills have 49% chance to Ignite
Supported Skills deal 10% increased Fire Damage
Enemies Ignited by Supported Skills have -19% to Fire Resistance
--------
This is a Support Gem. It does not grant a bonus to your character, but to skills in sockets connected to it. Place into an item socket connected to a socket containing the Active Skill Gem you wish to augment. Right click to remove from a socket.
--------
Corrupted
--------
Note: ~price 29 chaos
*/