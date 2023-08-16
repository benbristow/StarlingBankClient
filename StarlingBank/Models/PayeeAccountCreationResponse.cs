using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models;

public class PayeeAccountCreationResponse
{
    /// <summary>
    /// The newly created payee unique identifier, only present on successful payee account creation
    /// </summary>
    [JsonProperty("payeeAccountUid")]
    public string PayeeAccountUid { get; set; }

    /// <summary>
    /// True if the method completed successfully
    /// </summary>
    [JsonProperty("success")]
    public bool? Success { get; set; }


    [JsonProperty("errors")] public List<ErrorDetail> Errors { get; set; }
}