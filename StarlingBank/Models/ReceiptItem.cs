using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

public class ReceiptItem
{
    [JsonProperty("receiptItemUid")] public Guid? ReceiptItemUid { get; set; }


    [JsonProperty("description")] public string Description { get; set; }


    [JsonProperty("quantity")] public int? Quantity { get; set; }


    [JsonProperty("amount")] public double Amount { get; set; }


    [JsonProperty("tax")] public double Tax { get; set; }


    [JsonProperty("url")] public string Url { get; set; }

    /// <summary>
    /// The time the receipt item was created
    /// </summary>
    [JsonConverter(typeof(IsoDateTimeConverter))]
    [JsonProperty("creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>
    /// Type of receipt item. It can be PURCHASE, SERVICE_FEE, GRATUITY or null
    /// </summary>
    [JsonProperty("type", ItemConverterType = typeof(StringValuedEnumConverter))]
    public Type? Type { get; set; }


    [JsonProperty("notes")] public List<string> Notes { get; set; }


    [JsonProperty("subItems")] public List<ReceiptSubItem> SubItems { get; set; }
}