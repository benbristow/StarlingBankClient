using Newtonsoft.Json;

namespace StarlingBank.Models;

/// <summary>
/// Class AccountHolderName.
/// </summary>
public class AccountHolderName
{
    /// <value>The account holder name value.</value>
    [JsonProperty("accountHolderName")]
    public string AccountHolderNameValue { get; set; }
}