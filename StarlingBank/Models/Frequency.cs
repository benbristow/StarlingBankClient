using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

/// <summary>
/// FrequencyEnum
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum Frequency
{
    /// <summary>
    /// Secondly
    /// </summary>
    SECONDLY,

    /// <summary>
    /// Minutely
    /// </summary>
    MINUTELY,

    /// <summary>
    /// Hourly
    /// </summary>
    HOURLY,

    /// <summary>
    /// Daily
    /// </summary>
    DAILY,

    /// <summary>
    /// Weekly
    /// </summary>
    WEEKLY,

    /// <summary>
    /// Monthly
    /// </summary>
    MONTHLY,

    /// <summary>
    /// Yearly
    /// </summary>
    YEARLY,

    /// <summary>
    /// Millennialy
    /// </summary>
    MILLENNIALY,

    /// <summary>
    /// Working daily
    /// </summary>
    WORKING_DAILY,

    /// <summary>
    /// Scottish quarterly
    /// </summary>
    SCOTTISH_QUARTERLY,

    /// <summary>
    /// English quarterly
    /// </summary>
    ENGLISH_QUARTERLY,

    /// <summary>
    /// Received quarterly
    /// </summary>
    RECEIVED_QUARTERLY
}