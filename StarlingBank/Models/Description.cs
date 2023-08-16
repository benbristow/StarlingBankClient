namespace StarlingBank.Models;

/// <summary>
/// DescriptionEnum
/// </summary>
public enum Description
{
    /// <summary>
    /// Accepted
    /// </summary>
    ACCEPTED,

    /// <summary>
    /// Qualified accept within two hours
    /// </summary>
    QUALIFIED_ACCEPT_WITHIN_TWO_HOURS,

    /// <summary>
    /// Qualified accept unspecified day
    /// </summary>
    QUALIFIED_ACCEPT_UNSPECIFIED_DAY,

    /// <summary>
    /// Qualified accept same day
    /// </summary>
    QUALIFIED_ACCEPT_SAME_DAY,

    /// <summary>
    /// Qualified accept next calendar day
    /// </summary>
    QUALIFIED_ACCEPT_NEXT_CALENDAR_DAY,

    /// <summary>
    /// Qualified accept next working day
    /// </summary>
    QUALIFIED_ACCEPT_NEXT_WORKING_DAY,

    /// <summary>
    /// Qualified accept after next working day
    /// </summary>
    QUALIFIED_ACCEPT_AFTER_NEXT_WORKING_DAY,

    /// <summary>
    /// Destination account invalid
    /// </summary>
    DESTINATION_ACCOUNT_INVALID,

    /// <summary>
    /// Destination account name mismatch
    /// </summary>
    DESTINATION_ACCOUNT_NAME_MISMATCH,

    /// <summary>
    /// Reference information incorrect
    /// </summary>
    REFERENCE_INFORMATION_INCORRECT,

    /// <summary>
    /// Destination account unavailable
    /// </summary>
    DESTINATION_ACCOUNT_UNAVAILABLE,

    /// <summary>
    /// Pending
    /// </summary>
    PENDING
}