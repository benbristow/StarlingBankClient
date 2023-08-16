using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

public class Money
{
    [JsonProperty("currency", ItemConverterType = typeof(StringEnumConverter))]
    public Currency Currency { get; set; }


    [JsonProperty("amount")] public double Amount { get; set; }
}