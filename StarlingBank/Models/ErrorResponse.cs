using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models;

public class ErrorResponse
{
    [JsonProperty("errors")] public List<ErrorDetail> Errors { get; set; }


    [JsonProperty("success")] public bool? Success { get; set; }
}