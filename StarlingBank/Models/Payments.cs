using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models;

public class Payments
{
    [JsonProperty("payments")] public List<PayeePayment> PaymentsValue { get; set; }
}