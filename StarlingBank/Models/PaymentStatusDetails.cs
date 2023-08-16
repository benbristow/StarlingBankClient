using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

public class PaymentStatusDetails
{
    [JsonProperty("paymentStatus", ItemConverterType = typeof(StringEnumConverter))]
    public PaymentStatus? PaymentStatus { get; set; }


    [JsonProperty("description", ItemConverterType = typeof(StringEnumConverter))]
    public Description? Description { get; set; }
}