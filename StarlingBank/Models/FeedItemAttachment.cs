using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

public class FeedItemAttachment
{
    [JsonProperty("feedItemUid")] public Guid? FeedItemUid { get; set; }


    [JsonProperty("feedItemAttachmentUid")]
    public Guid? FeedItemAttachmentUid { get; set; }


    [JsonProperty("attachmentType", ItemConverterType = typeof(StringEnumConverter))]
    public AttachmentType? AttachmentType { get; set; }


    [JsonProperty("feedItemAttachmentType", ItemConverterType = typeof(StringEnumConverter))]
    public FeedItemAttachmentType? FeedItemAttachmentType { get; set; }
}