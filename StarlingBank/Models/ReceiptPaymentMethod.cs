using System;
using Newtonsoft.Json;

namespace StarlingBank.Models;

public class ReceiptPaymentMethod
{
    [JsonProperty("paymentMethodUid")] public Guid? PaymentMethodUid { get; set; }


    [JsonProperty("description")] public string Description { get; set; }


    [JsonProperty("amount")] public double Amount { get; set; }
}