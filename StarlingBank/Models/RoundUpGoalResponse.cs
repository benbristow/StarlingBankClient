using Newtonsoft.Json;

namespace StarlingBank.Models;

public class RoundUpGoalResponse
{
    [JsonProperty("active")] public bool? Active { get; set; }


    [JsonProperty("roundUpGoal")] public RoundUpGoalDetails RoundUpGoal { get; set; }


    [JsonProperty("roundUpGoalDetails")] public RoundUpGoalDetails RoundUpGoalDetails { get; set; }
}