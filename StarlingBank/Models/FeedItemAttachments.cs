using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models;

public class FeedItemAttachments
{
    [JsonProperty("feedItemAttachments")] public List<FeedItemAttachment> FeedItemAttachmentsValue { get; set; }
}