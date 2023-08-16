using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models;

public class SavingsGoalsV2
{
    [JsonProperty("savingsGoalList")] public List<SavingsGoalV2> SavingsGoalList { get; set; }
}