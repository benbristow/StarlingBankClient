using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
    [JsonProperty("accountHolderType", ItemConverterType = typeof(StringEnumConverter))]
    public AccountHolderType? AccountHolderType { get; set; }
}