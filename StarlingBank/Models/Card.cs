using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

/// <summary>
/// Class Card.
/// </summary>
public class Card
{
    /// <value>The card uid.</value>
    [JsonProperty("cardUid")]
    public Guid CardUid { get; set; }


    /// <value>The public token.</value>
    [JsonProperty("publicToken")]
    public string PublicToken { get; set; }


    /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
    [JsonProperty("enabled")]
    public bool Enabled { get; set; }


    /// <value><c>true</c> if [wallet notification enabled]; otherwise, <c>false</c>.</value>
    [JsonProperty("walletNotificationEnabled")]
    public bool WalletNotificationEnabled { get; set; }


    /// <value><c>true</c> if [position enabled]; otherwise, <c>false</c>.</value>
    [JsonProperty("posEnabled")]
    public bool PosEnabled { get; set; }


    /// <value><c>true</c> if [atm enabled]; otherwise, <c>false</c>.</value>
    [JsonProperty("atmEnabled")]
    public bool AtmEnabled { get; set; }


    /// <value><c>true</c> if [online enabled]; otherwise, <c>false</c>.</value>
    [JsonProperty("onlineEnabled")]
    public bool OnlineEnabled { get; set; }


    /// <value><c>true</c> if [mobile wallet enabled]; otherwise, <c>false</c>.</value>
    [JsonProperty("mobileWalletEnabled")]
    public bool MobileWalletEnabled { get; set; }


    /// <value><c>true</c> if [gambling enabled]; otherwise, <c>false</c>.</value>
    [JsonProperty("gamblingEnabled")]
    public bool GamblingEnabled { get; set; }


    /// <value><c>true</c> if [mag stripe enabled]; otherwise, <c>false</c>.</value>
    [JsonProperty("magStripeEnabled")]
    public bool MagStripeEnabled { get; set; }


    /// <value><c>true</c> if cancelled; otherwise, <c>false</c>.</value>
    [JsonProperty("cancelled")]
    public bool Cancelled { get; set; }


    /// <value><c>true</c> if [activation requested]; otherwise, <c>false</c>.</value>
    [JsonProperty("activationRequested")]
    public bool ActivationRequested { get; set; }


    /// <value><c>true</c> if activated; otherwise, <c>false</c>.</value>
    [JsonProperty("activated")]
    public bool Activated { get; set; }


    /// <value>The end of card number.</value>
    [JsonProperty("endOfCardNumber")]
    public string EndOfCardNumber { get; set; }


    /// <value>The currency flags.</value>
    [JsonProperty("currencyFlags")]
    public List<CurrencyFlag> CurrencyFlags { get; set; }


    /// <value>The card association uid.</value>
    [JsonProperty("cardAssociationUid")]
    public Guid CardAssociationUid { get; set; }


    /// <value>The gambling to be enabled at.</value>
    [JsonConverter(typeof(IsoDateTimeConverter))]
    [JsonProperty("gamblingToBeEnabledAt")]
    public DateTime? GamblingToBeEnabledAt { get; set; }
}