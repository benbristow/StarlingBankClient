using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

public class PayeeAccount
{
    /// <summary>
    /// The uid of this payee account
    /// </summary>
    [JsonProperty("payeeAccountUid")]
    public Guid? PayeeAccountUid { get; set; }

    /// <summary>
    /// The channel through which the payee was added
    /// </summary>
    [JsonProperty("payeeChannelType", ItemConverterType = typeof(StringEnumConverter))]
    public PayeeChannelType? PayeeChannelType { get; set; }

    /// <summary>
    /// Account description
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }

    /// <summary>
    /// Is this the default account for the owning payee
    /// </summary>
    [JsonProperty("defaultAccount")]
    public bool? DefaultAccount { get; set; }

    /// <summary>
    /// The country code for the account (ISO 3166-1 alpha-2)
    /// </summary>
    [JsonProperty("countryCode", ItemConverterType = typeof(StringEnumConverter))]
    public CountryCode? CountryCode { get; set; }

    /// <summary>
    /// The account identifier
    /// </summary>
    [JsonProperty("accountIdentifier")]
    public string AccountIdentifier { get; set; }

    /// <summary>
    /// The bank identifier
    /// </summary>
    [JsonProperty("bankIdentifier")]
    public string BankIdentifier { get; set; }

    /// <summary>
    /// The bank identifier type
    /// </summary>
    [JsonProperty("bankIdentifierType", ItemConverterType = typeof(StringEnumConverter))]
    public BankIdentifierType? BankIdentifierType { get; set; }


    [JsonProperty("lastReferences")] public List<string> LastReferences { get; set; }
}