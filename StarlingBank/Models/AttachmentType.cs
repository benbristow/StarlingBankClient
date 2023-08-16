using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models;

/// <summary>
/// Enum AttachmentType
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AttachmentType
{
    /// <summary>
    /// Image
    /// </summary>
    IMAGE,

    /// <summary>
    /// PDF
    /// </summary>
    PDF
}