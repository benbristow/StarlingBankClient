using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

public class SpendingCounterPartyBreakdown
{
    [JsonProperty("counterPartyUid")] public Guid? CounterPartyUid { get; set; }


    [JsonProperty("counterPartyType", ItemConverterType = typeof(StringEnumConverter))]
    public CounterPartyType? CounterPartyType { get; set; }


    [JsonProperty("counterPartyName")] public string CounterPartyName { get; set; }

    /// <summary>
    /// Amount spent at/sent to this counter party
    /// </summary>
    [JsonProperty("totalSpent")]
    public double? TotalSpent { get; set; }

    /// <summary>
    /// Amount received from this counter party
    /// </summary>
    [JsonProperty("totalReceived")]
    public double? TotalReceived { get; set; }


    [JsonProperty("netSpend")] public double? NetSpend { get; set; }

    /// <summary>
    /// IN if totalReceived > totalSpent else OUT
    /// </summary>
    [JsonProperty("netDirection", ItemConverterType = typeof(StringEnumConverter))]
    public NetDirection? NetDirection { get; set; }


    [JsonProperty("currency", ItemConverterType = typeof(StringEnumConverter))]
    public Currency? Currency { get; set; }

    /// <summary>
    /// Percentage that the netSpend makes up of the sum of the netSpends of breakdowns in the same period with the same netDirection
    /// </summary>
    [JsonProperty("percentage")]
    public double? Percentage { get; set; }


    [JsonProperty("transactionCount")] public long? TransactionCount { get; set; }
}