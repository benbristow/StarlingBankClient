using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models;

public class Payees
{
    [JsonProperty("payees")] public List<Payee> PayeesValue { get; set; }
}