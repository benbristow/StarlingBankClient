using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models;

public class FeedItems
{
    [JsonProperty("feedItems")] public List<FeedItem> FeedItemsValue { get; set; }
}