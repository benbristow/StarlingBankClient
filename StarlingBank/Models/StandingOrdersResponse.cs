using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models;

public class StandingOrdersResponse
{
    [JsonProperty("standingOrders")] public List<StandingOrder> StandingOrders { get; set; }
}