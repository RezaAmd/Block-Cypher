using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlockCypher.Api.Models
{
    public class BCAccountInfo
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("limits")]
        public BCLimits Limits { get; set; }
        [JsonProperty("hits_history")]
        public List<BCHitHistory> hits { get; set; }
    }

    public class BCLimits
    {
        [JsonProperty("api/day")]
        public int PerDay { get; set; }
        [JsonProperty("api/hour")]
        public int PerHour { get; set; }
        [JsonProperty("api/second")]
        public int PerSecond { get; set; }
        [JsonProperty("confidence/hour")]
        public int ConfidencePerHour { get; set; }
        [JsonProperty("hooks")]
        public int Hooks { get; set; }
        [JsonProperty("hooks/hour")]
        public int HooksPerHour { get; set; }
    }

    public class BCHitHistory
    {
        [JsonProperty("api/hour")]
        public int PerHour { get; set; }
        [JsonProperty("time")]
        public string Time { get; set; }
    }
}