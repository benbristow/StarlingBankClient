using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models;

/// <summary>
/// Class Accounts.
/// </summary>
public class Accounts
{
    /// <value>The accounts value.</value>
    [JsonProperty("accounts")]
    public List<AccountV2> AccountsValue { get; set; }
}