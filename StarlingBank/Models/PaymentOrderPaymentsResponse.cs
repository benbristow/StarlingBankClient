using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models;

public class PaymentOrderPaymentsResponse
{
    [JsonProperty("payments")] public List<PaymentOrderPayment> Payments { get; set; }
}