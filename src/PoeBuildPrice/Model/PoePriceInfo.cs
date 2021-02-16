using Newtonsoft.Json;

namespace PoeBuildPrice.Model {
    public class PoePriceInfo
    {
        public decimal Min { get; set; }

        public decimal Max { get; set; }

        public string Currency { get; set; }

        [JsonProperty("error")]
        public int ErrorCode { get; set; }

        [JsonProperty("pred_confidence_score")]
        public decimal? ConfidenceScore { get; set; }

        public decimal AvgPriceInChaos
        {
            get
            {
                var avg = (Min + Max) / 2;
                return Currency == "exalt" ? avg * 100 : avg;
            }
        }
    }
}