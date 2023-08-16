using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

/// <summary>
/// Class AccountV2.
/// </summary>
public class AccountV2
{
    /// <value>The account uid.</value>
    [JsonProperty("accountUid")]
    public Guid? AccountUid { get; set; }


    /// <value>The type of the account.</value>
    [JsonProperty("accountType", ItemConverterType = typeof(StringEnumConverter))]
    public AccountType? AccountType { get; set; }


    /// <value>The default category.</value>
    [JsonProperty("defaultCategory")]
    public Guid? DefaultCategory { get; set; }


    /// <value>The currency.</value>
    [JsonProperty("currency", ItemConverterType = typeof(StringEnumConverter))]
    public Currency? Currency { get; set; }


    /// <value>The created at.</value>
    [JsonConverter(typeof(IsoDateTimeConverter))]
    [JsonProperty("createdAt")]
    public DateTime? CreatedAt { get; set; }


    /// <value>The name.</value>
    [JsonProperty("name")]
    public string Name { get; set; }
}