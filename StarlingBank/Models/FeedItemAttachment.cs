using System;
using Newtonsoft.Json;

namespace StarlingBank.Models;

public class FeedItemAttachment
{
    [JsonProperty("feedItemUid")] public Guid? FeedItemUid { get; set; }


    [JsonProperty("feedItemAttachmentUid")]
    public Guid? FeedItemAttachmentUid { get; set; }


    [JsonProperty("attachmentType", ItemConverterType = typeof(StringValuedEnumConverter))]
    public AttachmentType? AttachmentType { get; set; }


    [JsonProperty("feedItemAttachmentType", ItemConverterType = typeof(StringValuedEnumConverter))]
    public FeedItemAttachmentType? FeedItemAttachmentType { get; set; }
}