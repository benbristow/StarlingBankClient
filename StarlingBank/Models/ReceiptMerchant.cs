using System;
using Newtonsoft.Json;

namespace StarlingBank.Models;

public class ReceiptMerchant
{
    [JsonProperty("receiptMerchantUid")] public Guid? ReceiptMerchantUid { get; set; }


    [JsonProperty("identifier")] public string Identifier { get; set; }


    [JsonProperty("address")] public string Address { get; set; }


    [JsonProperty("emailAddress")] public string EmailAddress { get; set; }


    [JsonProperty("logoUrl")] public string LogoUrl { get; set; }


    [JsonProperty("orderCollectionNumber")]
    public string OrderCollectionNumber { get; set; }


    [JsonProperty("taxNumber")] public string TaxNumber { get; set; }
}