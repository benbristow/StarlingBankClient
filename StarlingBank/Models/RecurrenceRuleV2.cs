using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using StarlingBank.Utilities;

namespace StarlingBank.Models;

public class RecurrenceRuleV2
{
    [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
    [JsonProperty("startDate")]
    public DateTime StartDate { get; set; }


    [JsonProperty("frequency", ItemConverterType = typeof(StringEnumConverter))]
    public Frequency Frequency { get; set; }


    [JsonProperty("interval")] public int? Interval { get; set; }


    [JsonProperty("count")] public int? Count { get; set; }


    [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
    [JsonProperty("untilDate")]
    public DateTime? UntilDate { get; set; }


    [JsonProperty("days", ItemConverterType = typeof(StringEnumConverter))]
    public List<Day> Days { get; set; }
}