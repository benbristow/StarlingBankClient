using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

public class CreateStandingOrderRequest
{
    /// <summary>
    /// External identifier for the standing order request
    /// </summary>
    [JsonProperty("externalIdentifier")]
    public string ExternalIdentifier { get; set; }


    [JsonProperty("destinationPayeeAccountUid")]
    public Guid DestinationPayeeAccountUid { get; set; }

    /// <summary>
    /// The payment reference
    /// </summary>
    [JsonProperty("reference")]
    public string Reference { get; set; }

    /// <summary>
    /// Representation of money
    /// </summary>
    [JsonProperty("amount")]
    public CurrencyAndAmount Amount { get; set; }

    /// <summary>
    /// Recurrence rules of a standing order
    /// </summary>
    [JsonProperty("standingOrderRecurrence")]
    public StandingOrderRecurrence StandingOrderRecurrence { get; set; }

    /// <summary>
    /// Optional spending category to associate with this payment
    /// </summary>
    [JsonProperty("spendingCategory", ItemConverterType = typeof(StringEnumConverter))]
    public SpendingCategory? SpendingCategory { get; set; }
}