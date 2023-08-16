using System.ComponentModel;

namespace StarlingBank.Models;

/// <summary>
/// FeedItemAttachmentTypeEnum
/// </summary>
public enum FeedItemAttachmentType
{
    /// <summary>
    /// Image
    /// </summary>
    IMAGE,

    /// <summary>
    /// PDF
    /// </summary>
    PDF,

    /// <summary>
    /// Either image or PDF
    /// </summary>
    [Description("IMAGE, PDF")]
    IMAGE_PDF
}