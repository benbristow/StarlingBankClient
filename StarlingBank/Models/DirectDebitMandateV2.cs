using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using StarlingBank.Utilities;

namespace StarlingBank.Models;

public class DirectDebitMandateV2
{
    [JsonProperty("uid")] public Guid? Uid { get; set; }


    [JsonProperty("reference")] public string Reference { get; set; }


    [JsonProperty("status", ItemConverterType = typeof(StringEnumConverter))]
    public Status? Status { get; set; }


    [JsonProperty("source", ItemConverterType = typeof(StringEnumConverter))]
    public Source? Source { get; set; }


    [JsonConverter(typeof(IsoDateTimeConverter))]
    [JsonProperty("created")]
    public DateTime? Created { get; set; }


    [JsonConverter(typeof(IsoDateTimeConverter))]
    [JsonProperty("cancelled")]
    public DateTime? Cancelled { get; set; }


    [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
    [JsonProperty("nextDate")]
    public DateTime? NextDate { get; set; }


    [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
    [JsonProperty("lastDate")]
    public DateTime? LastDate { get; set; }


    [JsonProperty("originatorName")] public string OriginatorName { get; set; }


    [JsonProperty("originatorUid")] public Guid? OriginatorUid { get; set; }


    [JsonProperty("merchantUid")] public Guid? MerchantUid { get; set; }

    /// <summary>
    /// Last direct debit payment
    /// </summary>
    [JsonProperty("lastPayment")]
    public LastPayment LastPayment { get; set; }
}