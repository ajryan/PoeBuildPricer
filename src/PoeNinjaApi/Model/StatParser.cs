using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace PoeNinjaApi.Model {
    /// <summary>
    /// Match "specific" stat lines by "genericized" matching
    /// </summary>
    public static class StatParser {
        private static readonly List<string> EMPTY_STR_LIST = new List<string>();

        public static List<string> ParseModifiersFromStats(ItemData item) {
            return (item.CraftedMods ?? EMPTY_STR_LIST)
                .Concat(item.EnchantMods ?? EMPTY_STR_LIST)
                .Concat(item.ExplicitMods ?? EMPTY_STR_LIST)
                .Concat(item.ImplicitMods ?? EMPTY_STR_LIST)
                .Concat(item.FracturedMods  ?? EMPTY_STR_LIST)
                .Select(stat => DigitsToHashes(stat))
                .ToList();
        }

        private static readonly Regex _digitRegex = new Regex(@"\d+", RegexOptions.Compiled);

        private static string DigitsToHashes(string statLine) {
            return _digitRegex.Replace(statLine, "#");
        }
    }
}