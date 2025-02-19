using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

/// <summary>
/// Class AccountIdentifier.
/// </summary>
public class AccountIdentifier
{
    /// <value>The type of the identifier.</value>
    [JsonProperty("identifierType", ItemConverterType = typeof(StringEnumConverter))]
    public IdentifierType? IdentifierType { get; set; }

    /// <summary>
    /// Identifier to uniquely identify the bank, e.g. a sort code or BIC
    /// </summary>
    /// <value>The bank identifier.</value>
    [JsonProperty("bankIdentifier")]
    public string BankIdentifier { get; set; }

    /// <summary>
    /// Identifier to uniquely identify the account at the bank, e.g. an account number or IBAN
    /// </summary>
    /// <value>The account identifier value.</value>
    [JsonProperty("accountIdentifier")]
    public string AccountIdentifierValue { get; set; }
}