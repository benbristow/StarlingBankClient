using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models;

/// <summary>
/// Class AddressesV2.
/// </summary>
public class AddressesV2
{
    /// <summary>
    /// Physical address of account holder
    /// </summary>
    /// <value>The current.</value>
    [JsonProperty("current")]
    public AddressV2 Current { get; set; }

    /// <value>The previous.</value>
    [JsonProperty("previous")]
    public List<AddressV2> Previous { get; set; }
}