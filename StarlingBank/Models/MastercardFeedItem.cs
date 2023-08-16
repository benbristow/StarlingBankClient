using Newtonsoft.Json;

namespace StarlingBank.Models;

public class MastercardFeedItem
{
    [JsonProperty("merchantIdentifier")] public string MerchantIdentifier { get; set; }


    [JsonProperty("mcc")] public int? Mcc { get; set; }


    [JsonProperty("posTimestamp")] public LocalTime PosTimestamp { get; set; }


    [JsonProperty("authorisationCode")] public string AuthorisationCode { get; set; }


    [JsonProperty("cardLast4")] public string CardLast4 { get; set; }
}