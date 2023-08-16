using Newtonsoft.Json;

namespace StarlingBank.Models;

/// <summary>
/// Class Business.
/// </summary>
public class Business
{
    /// <value>The name of the company.</value>
    [JsonProperty("companyName")]
    public string CompanyName { get; set; }


    /// <value>The type of the company.</value>
    [JsonProperty("companyType")]
    public string CompanyType { get; set; }


    /// <value>The company category.</value>
    [JsonProperty("companyCategory")]
    public string CompanyCategory { get; set; }


    /// <value>The company sub category.</value>
    [JsonProperty("companySubCategory")]
    public string CompanySubCategory { get; set; }


    /// <value>The company registration number.</value>
    [JsonProperty("companyRegistrationNumber")]
    public string CompanyRegistrationNumber { get; set; }


    /// <value>The email.</value>
    [JsonProperty("email")]
    public string Email { get; set; }


    /// <value>The phone.</value>
    [JsonProperty("phone")]
    public string Phone { get; set; }
}