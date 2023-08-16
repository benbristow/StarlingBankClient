using System;
using Newtonsoft.Json;

namespace StarlingBank.Models;

/// <summary>
/// Class AccountHolder.
/// </summary>
public class AccountHolder
{
    /// <value>The account holder uid.</value>
    [JsonProperty("accountHolderUid")]
    public Guid? AccountHolderUid { get; set; }


    /// <value>The type of the account holder.</value>
    [JsonProperty("accountHolderType", ItemConverterType = typeof(StringValuedEnumConverter))]
    public AccountHolderType? AccountHolderType { get; set; }
}