using System;
using Newtonsoft.Json;

namespace StarlingBank.Models;

public class JointAccount
{
    [JsonProperty("accountHolderUid")] public Guid? AccountHolderUid { get; set; }

    /// <summary>
    /// Information about an individual account holder
    /// </summary>
    [JsonProperty("personOne")]
    public Individual PersonOne { get; set; }

    /// <summary>
    /// Information about an individual account holder
    /// </summary>
    [JsonProperty("personTwo")]
    public Individual PersonTwo { get; set; }
}