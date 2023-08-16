using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

public class KycResult
{
    [JsonConverter(typeof(IsoDateTimeConverter))]
    [JsonProperty("issuedTimestamp")]
    public DateTime? IssuedTimestamp { get; set; }


    [JsonProperty("fraudDecision")] public string FraudDecision { get; set; }


    [JsonProperty("amlDecision")] public string AmlDecision { get; set; }


    [JsonProperty("bureau")] public string Bureau { get; set; }
}