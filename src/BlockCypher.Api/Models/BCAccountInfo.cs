using Newtonsoft.Json;

namespace BlockCypher.Api.Models
{
    public class BCAccountInfo
    {
        public string token { get; set; }
        public BCLimits limits { get; set; }
        public BCHits hits { get; set; }
    }

    public class BCLimits
    {
        [JsonProperty("api/day")]
        public int perDay { get; set; }
        [JsonProperty("api/hour")]
        public int perHour { get; set; }
        [JsonProperty("api/second")]
        public int perSecond { get; set; }
        [JsonProperty("confidence/hour")]
        public int confidencePerHour { get; set; }
        [JsonProperty("hooks")]
        public int Hooks { get; set; }
        [JsonProperty("hooks/hour")]
        public int hooksPerHour { get; set; }
    }

    public class BCHits
    {
        [JsonProperty("api/hour")]
        public int perHour { get; set; }
    }
}