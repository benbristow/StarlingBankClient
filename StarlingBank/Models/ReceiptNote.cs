using System;
using Newtonsoft.Json;

namespace StarlingBank.Models;

public class ReceiptNote
{
    [JsonProperty("noteUid")] public Guid? NoteUid { get; set; }


    [JsonProperty("title")] public string Title { get; set; }


    [JsonProperty("description")] public string Description { get; set; }


    [JsonProperty("url")] public string Url { get; set; }
}