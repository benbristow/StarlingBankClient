using Newtonsoft.Json;

namespace StarlingBank.Models;

public class LocalTime
{
    [JsonProperty("hour")] public int? Hour { get; set; }


    [JsonProperty("minute")] public int? Minute { get; set; }


    [JsonProperty("second")] public int? Second { get; set; }


    [JsonProperty("nano")] public int? Nano { get; set; }
}