using Newtonsoft.Json;

namespace StarlingBank.Models;

public class UserNoteWrapper
{
    [JsonProperty("userNote")] public string UserNote { get; set; }
}