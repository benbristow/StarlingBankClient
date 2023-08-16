using Newtonsoft.Json;

namespace StarlingBank.Models;

/// <summary>
/// Class BalanceV2.
/// </summary>
public class BalanceV2
{
    /// <value>The cleared balance.</value>
    [JsonProperty("clearedBalance")]
    public SignedCurrencyAndAmount ClearedBalance { get; set; }


    /// <value>The effective balance.</value>
    [JsonProperty("effectiveBalance")]
    public SignedCurrencyAndAmount EffectiveBalance { get; set; }


    /// <value>The pending transactions.</value>
    [JsonProperty("pendingTransactions")]
    public SignedCurrencyAndAmount PendingTransactions { get; set; }


    /// <value>The accepted overdraft.</value>
    [JsonProperty("acceptedOverdraft")]
    public SignedCurrencyAndAmount AcceptedOverdraft { get; set; }


    /// <value>The amount.</value>
    [JsonProperty("amount")]
    public SignedCurrencyAndAmount Amount { get; set; }
}