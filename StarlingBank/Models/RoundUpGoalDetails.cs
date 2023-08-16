using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

public class RoundUpGoalDetails
{
    [JsonProperty("primaryCategoryUid")] public Guid PrimaryCategoryUid { get; set; }


    [JsonProperty("roundUpGoalUid")] public Guid RoundUpGoalUid { get; set; }


    [JsonProperty("roundUpMultiplier")] public double RoundUpMultiplier { get; set; }


    [JsonConverter(typeof(IsoDateTimeConverter))]
    [JsonProperty("activatedAt")]
    public DateTime ActivatedAt { get; set; }


    [JsonProperty("activatedBy")] public Guid ActivatedBy { get; set; }
}