using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

public class SettleUpProfile
{
    /// <summary>
    /// Status
    /// </summary>
    [JsonProperty("status", ItemConverterType = typeof(StringEnumConverter))]
    public Status Status { get; set; }


    [JsonProperty("starlingPayLink")] public string StarlingPayLink { get; set; }

    /// <summary>
    /// Settle Up link
    /// </summary>
    [JsonProperty("settleUpLink")]
    public string SettleUpLink { get; set; }
}