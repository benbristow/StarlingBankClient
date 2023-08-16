using Newtonsoft.Json;

namespace StarlingBank.Models;

public class Money
{
    [JsonProperty("currency", ItemConverterType = typeof(StringValuedEnumConverter))]
    public Currency Currency { get; set; }


    [JsonProperty("amount")] public double Amount { get; set; }
}