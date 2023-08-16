using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models;

public class DirectDebitMandatesV2
{
    [JsonProperty("mandates")] public List<DirectDebitMandateV2> Mandates { get; set; }
}