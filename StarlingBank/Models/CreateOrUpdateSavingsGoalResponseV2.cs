using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models;

public class CreateOrUpdateSavingsGoalResponseV2
{
    /// <summary>
    /// Unique identifier of the savings goal
    /// </summary>
    [JsonProperty("savingsGoalUid")]
    public Guid? SavingsGoalUid { get; set; }

    /// <summary>
    /// True if the method completed successfully
    /// </summary>
    [JsonProperty("success")]
    public bool? Success { get; set; }


    [JsonProperty("error")] public List<ErrorDetail> Error { get; set; }


    [JsonProperty("errors")] public List<ErrorDetail> Errors { get; set; }
}