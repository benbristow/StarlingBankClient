using Newtonsoft.Json;

namespace StarlingBank.Models;

public class UpdateSpendingCategory
{
    [JsonProperty("spendingCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
    public SpendingCategory SpendingCategory { get; set; }


    [JsonProperty("permanentSpendingCategoryUpdate")]
    public bool? PermanentSpendingCategoryUpdate { get; set; }


    [JsonProperty("previousSpendingCategoryReferencesUpdate")]
    public bool? PreviousSpendingCategoryReferencesUpdate { get; set; }
}