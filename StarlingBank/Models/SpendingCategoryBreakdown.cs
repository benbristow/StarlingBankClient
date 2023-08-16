using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

public class SpendingCategoryBreakdown
{
    [JsonProperty("spendingCategory", ItemConverterType = typeof(StringEnumConverter))]
    public SpendingCategory SpendingCategory { get; set; }

    /// <summary>
    /// Amount spent under this spending category
    /// </summary>
    [JsonProperty("totalSpent")]
    public double? TotalSpent { get; set; }

    /// <summary>
    /// Amount received under this spending category
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