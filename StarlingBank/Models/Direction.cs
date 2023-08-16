using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

/// <summary>
/// DirectionEnum
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum Direction
{
    /// <summary>
    /// In
    /// </summary>
    IN,

    /// <summary>
    /// Out
    /// </summary>
    OUT
}