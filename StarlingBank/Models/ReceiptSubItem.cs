using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models;

public class ReceiptSubItem
{
    [JsonProperty("receiptSubItemUid")] public Guid? ReceiptSubItemUid { get; set; }


    [JsonProperty("description")] public string Description { get; set; }


    [JsonProperty("quantity")] public int? Quantity { get; set; }


    [JsonProperty("amount")] public double? Amount { get; set; }


    [JsonProperty("notes")] public List<string> Notes { get; set; }
}