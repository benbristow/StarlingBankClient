using Newtonsoft.Json;

namespace StarlingBank.Models;

public class PaymentStatusDetails
{
    [JsonProperty("paymentStatus", ItemConverterType = typeof(StringValuedEnumConverter))]
    public PaymentStatus? PaymentStatus { get; set; }


    [JsonProperty("description", ItemConverterType = typeof(StringValuedEnumConverter))]
    public Description? Description { get; set; }
}