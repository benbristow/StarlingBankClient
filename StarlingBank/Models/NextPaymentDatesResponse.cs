using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using StarlingBank.Utilities;

namespace StarlingBank.Models;

public class NextPaymentDatesResponse
{
    [JsonConverter(typeof(ListDateTimeConverter), typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
    [JsonProperty("nextPaymentDates")]
    public List<DateTime> NextPaymentDates { get; set; }
}