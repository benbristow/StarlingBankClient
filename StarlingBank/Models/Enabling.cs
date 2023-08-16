using Newtonsoft.Json;

namespace StarlingBank.Models;

public class Enabling
{
    [JsonProperty("enabled")] public bool Enabled { get; set; }
}