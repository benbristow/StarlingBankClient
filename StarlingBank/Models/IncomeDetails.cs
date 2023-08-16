using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

public class IncomeDetails
{
    /// <summary>
    /// Representation of money
    /// </summary>
    [JsonProperty("annualIncome")]
    public CurrencyAndAmount AnnualIncome { get; set; }

    /// <summary>
    /// Account holder's source of funds
    /// </summary>
    [JsonProperty("sourceOfFunds", ItemConverterType = typeof(StringEnumConverter))]
    public List<SourceOfFund> SourceOfFunds { get; set; }
}