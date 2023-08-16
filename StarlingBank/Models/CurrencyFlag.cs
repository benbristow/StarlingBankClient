using Newtonsoft.Json;

namespace StarlingBank.Models;

public class CurrencyFlag
{
    [JsonProperty("enabled")] public bool Enabled { get; set; }


    [JsonProperty("currency")] public string Currency { get; set; }
}