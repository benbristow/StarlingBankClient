using System;
using Newtonsoft.Json;
using StarlingBank.Utilities;

namespace StarlingBank.Models;

public class Individual
{
    [JsonProperty("title")] public string Title { get; set; }


    [JsonProperty("firstName")] public string FirstName { get; set; }


    [JsonProperty("lastName")] public string LastName { get; set; }


    [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
    [JsonProperty("dateOfBirth")]
    public DateTime? DateOfBirth { get; set; }


    [JsonProperty("email")] public string Email { get; set; }


    [JsonProperty("phone")] public string Phone { get; set; }
}