using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

public class Receipt
{
    [JsonProperty("receiptUid")] public Guid? ReceiptUid { get; set; }


    [JsonProperty("feedItemUid")] public Guid? FeedItemUid { get; set; }


    [JsonProperty("metadataSource", ItemConverterType = typeof(StringEnumConverter))]
    public MetadataSource MetadataSource { get; set; }


    [JsonProperty("receiptIdentifier")] public string ReceiptIdentifier { get; set; }


    [JsonProperty("totalAmount")] public double TotalAmount { get; set; }

    /// <summary>
    /// Receipt Merchant Information
    /// </summary>
    [JsonProperty("receiptMerchant")]
    public ReceiptMerchant ReceiptMerchant { get; set; }

    /// <summary>
    /// ISO-4217 3 character currency code
    /// </summary>
    [JsonProperty("currencyCode", ItemConverterType = typeof(StringEnumConverter))]
    public CurrencyCode? CurrencyCode { get; set; }


    [JsonProperty("items")] public List<ReceiptItem> Items { get; set; }


    [JsonProperty("notes")] public List<ReceiptNote> Notes { get; set; }


    [JsonProperty("taxDetails")] public List<ReceiptTaxDetail> TaxDetails { get; set; }


    [JsonProperty("paymentMethods")] public List<ReceiptPaymentMethod> PaymentMethods { get; set; }


    [JsonProperty("providerName")] public string ProviderName { get; set; }
}