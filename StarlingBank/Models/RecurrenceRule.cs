using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using StarlingBank.Utilities;

namespace StarlingBank.Models;

public class RecurrenceRule
{
    [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
    [JsonProperty("startDate")]
    public DateTime StartDate { get; set; }


    [JsonProperty("frequency", ItemConverterType = typeof(StringValuedEnumConverter))]
    public Frequency Frequency { get; set; }


    [JsonProperty("interval")] public int? Interval { get; set; }


    [JsonProperty("count")] public int? Count { get; set; }


    [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
    [JsonProperty("untilDate")]
    public DateTime? UntilDate { get; set; }


    [JsonProperty("weekStart", ItemConverterType = typeof(StringValuedEnumConverter))]
    public WeekStart? WeekStart { get; set; }


    [JsonProperty("days", ItemConverterType = typeof(StringValuedEnumConverter))]
    public List<Day> Days { get; set; }


    [JsonProperty("monthDay")] public int? MonthDay { get; set; }


    [JsonProperty("monthWeek")] public int? MonthWeek { get; set; }
}