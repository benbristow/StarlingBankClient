using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

public class ReceiptTaxDetail
{
    [JsonProperty("receiptTaxDetailUid")] public Guid? ReceiptTaxDetailUid { get; set; }


    [JsonProperty("taxName")] public string TaxName { get; set; }


    [JsonProperty("taxValue")] public double TaxValue { get; set; }


    [JsonProperty("taxCurrencyCode", ItemConverterType = typeof(StringValuedEnumConverter))]
    public TaxCurrencyCode TaxCurrencyCode { get; set; }

    /// <summary>
    /// The time the tax detail was created
    /// </summary>
    [JsonConverter(typeof(IsoDateTimeConverter))]
    [JsonProperty("creationTime")]
    public DateTime? CreationTime { get; set; }
}