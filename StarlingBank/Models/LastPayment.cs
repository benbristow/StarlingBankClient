using System;
using Newtonsoft.Json;
using StarlingBank.Utilities;

namespace StarlingBank.Models;

public class LastPayment
{
    [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
    [JsonProperty("lastDate")]
    public DateTime? LastDate { get; set; }

    /// <summary>
    /// Representation of money
    /// </summary>
    [JsonProperty("lastAmount")]
    public CurrencyAndAmount LastAmount { get; set; }
}