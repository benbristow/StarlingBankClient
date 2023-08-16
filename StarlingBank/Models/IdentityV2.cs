using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

public class IdentityV2
{
    [JsonProperty("accountHolderUid")] public Guid? AccountHolderUid { get; set; }


    [JsonConverter(typeof(IsoDateTimeConverter))]
    [JsonProperty("expiresAt")]
    public DateTime? ExpiresAt { get; set; }


    [JsonProperty("expiresInSeconds")] public long? ExpiresInSeconds { get; set; }

    /// <summary>
    /// The scopes which this token has permission to use e.g. balance:read
    /// </summary>
    [JsonProperty("scopes")]
    public List<string> Scopes { get; set; }


    [JsonProperty("authenticated")] public bool? Authenticated { get; set; }


    [JsonProperty("applicationUserUid")] public Guid? ApplicationUserUid { get; set; }

    /// <summary>
    /// Deprecated, use accountHolderUid instead
    /// </summary>
    [JsonProperty("customerUid")]
    public Guid? CustomerUid { get; set; }
}