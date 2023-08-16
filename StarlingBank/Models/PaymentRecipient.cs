using Newtonsoft.Json;

namespace StarlingBank.Models;

public class PaymentRecipient
{
    [JsonProperty("payeeName")] public string PayeeName { get; set; }


    [JsonProperty("payeeType", ItemConverterType = typeof(StringValuedEnumConverter))]
    public PayeeType PayeeType { get; set; }

    /// <summary>
    /// The country code for the account (ISO 3166-1 alpha-2)
    /// </summary>
    [JsonProperty("countryCode")]
    public string CountryCode { get; set; }


    [JsonProperty("accountIdentifier")] public string AccountIdentifier { get; set; }


    [JsonProperty("bankIdentifier")] public string BankIdentifier { get; set; }


    [JsonProperty("bankIdentifierType", ItemConverterType = typeof(StringValuedEnumConverter))]
    public BankIdentifierType BankIdentifierType { get; set; }
}