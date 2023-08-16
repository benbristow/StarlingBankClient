using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models;

/// <summary>
/// Class Cards.
/// </summary>
public class Cards
{
    /// <value>The cards value.</value>
    [JsonProperty("cards")]
    public List<Card> CardsValue { get; set; }
}