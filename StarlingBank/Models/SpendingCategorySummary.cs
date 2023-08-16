using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

public class SpendingCategorySummary
{
    [JsonProperty("period")] public string Period { get; set; }

    /// <summary>
    /// Amount spent from the account in the month
    /// </summary>
    [JsonProperty("totalSpent")]
    public double? TotalSpent { get; set; }

    /// <summary>
    /// Amount received to the account in the month
    /// </summary>
    [JsonProperty("totalReceived")]
    public double? TotalReceived { get; set; }

    /// <summary>
    /// |totalReceived - totalSpent|, i.e. how much the balance has changed in the month
    /// </summary>
    [JsonProperty("netSpend")]
    public double? NetSpend { get; set; }

    /// <summary>
    /// Sum of netSpend for spending categories whose net direction for the month is OUT
    /// </summary>
    [JsonProperty("totalSpendNetOut")]
    public double? TotalSpendNetOut { get; set; }

    /// <summary>
    /// Sum of netSpend for spending categories whose net direction for the month is IN
    /// </summary>
    [JsonProperty("totalReceivedNetIn")]
    public double? TotalReceivedNetIn { get; set; }


    [JsonProperty("currency", ItemConverterType = typeof(StringEnumConverter))]
    public Currency? Currency { get; set; }

    /// <summary>
    /// IN if totalReceived > totalSpent else OUT
    /// </summary>
    [JsonProperty("direction", ItemConverterType = typeof(StringEnumConverter))]
    public Direction? Direction { get; set; }


    [JsonProperty("breakdown")] public List<SpendingCategoryBreakdown> Breakdown { get; set; }
}