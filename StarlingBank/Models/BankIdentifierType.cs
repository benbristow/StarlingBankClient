namespace StarlingBank.Models;

/// <summary>
/// Enum BankIdentifierType
/// </summary>
public enum BankIdentifierType
{
    /// <summary>
    /// Sort Code Bank Identifier
    /// </summary>
    SORT_CODE,

    /// <summary>
    /// Swift Bank Identifier
    /// </summary>
    SWIFT,

    /// <summary>
    /// Iban Bank Identifier
    /// </summary>
    IBAN,

    /// <summary>
    /// Aba Bank Identifier
    /// </summary>
    ABA,

    /// <summary>
    /// Aba Wire Bank Identifier
    /// </summary>
    ABA_WIRE,

    /// <summary>
    /// Aba Ach  Bank Identifier
    /// </summary>
    ABA_ACH
}