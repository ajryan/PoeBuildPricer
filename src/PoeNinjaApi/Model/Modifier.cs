using System.Collections.Generic;
using Newtonsoft.Json;

namespace PoeNinjaApi.Model
{
    public class Modifier {
        public string Type { get; set; }
        public ModifierStat Stat { get; set; }
        public List<string> Values { get; } = new List<string>();
    }

    public class ModifierStat {
        public string Ref { get; set; }
        public Stat Stat { get; set; }
    }

    public class Stat
    {
        [JsonProperty("stat")]
        public StatRef StatRef { get; set; }
        public StatTrade Trade { get; set; }
    }

    public class StatRef {
        public string Ref { get; set; }
        public StatMatcher[] Matchers { get; set; }
    }

    public class StatMatcher
    {
        [JsonProperty("string")]
        public string MatchString;

        [JsonProperty("negate")]
        public bool Negate;

        [JsonProperty("value")]
        public int Value;
    }

    public class StatTrade {
        public bool? Inverted { get; set; }
        public string Option { get; set; } // "num" or "str"
        public Dictionary<string, string[]> Ids { get; set; }
    }
}