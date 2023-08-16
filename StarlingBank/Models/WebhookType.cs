namespace StarlingBank.Models;

/// <summary>
/// WebhookTypeEnum
/// </summary>
public enum WebhookType
{
    /// <summary>
    /// Interest charge
    /// </summary>
    INTEREST_CHARGE,

    /// <summary>
    /// Scheduled payment cancelled
    /// </summary>
    SCHEDULED_PAYMENT_CANCELLED,

    /// <summary>
    /// Scheduled payment insufficient funds
    /// </summary>
    SCHEDULED_PAYMENT_INSUFFICIENT_FUNDS,

    /// <summary>
    /// Transaction card
    /// </summary>
    TRANSACTION_CARD,

    /// <summary>
    /// Transaction cash withdrawal
    /// </summary>
    TRANSACTION_CASH_WITHDRAWAL,

    /// <summary>
    /// Transaction mobile wallet
    /// </summary>
    TRANSACTION_MOBILE_WALLET,

    /// <summary>
    /// Transaction direct credit
    /// </summary>
    TRANSACTION_DIRECT_CREDIT,

    /// <summary>
    /// Transaction direct debit
    /// </summary>
    TRANSACTION_DIRECT_DEBIT,

    /// <summary>
    /// Transaction direct debit insufficient funds
    /// </summary>
    TRANSACTION_DIRECT_DEBIT_INSUFFICIENT_FUNDS,

    /// <summary>
    /// Transaction direct debit dispute
    /// </summary>
    TRANSACTION_DIRECT_DEBIT_DISPUTE,

    /// <summary>
    /// Transaction faster payment in
    /// </summary>
    TRANSACTION_FASTER_PAYMENT_IN,

    /// <summary>
    /// Transaction faster payment out
    /// </summary>
    TRANSACTION_FASTER_PAYMENT_OUT,

    /// <summary>
    /// Transaction faster payment reversal
    /// </summary>
    TRANSACTION_FASTER_PAYMENT_REVERSAL,

    /// <summary>
    /// Transaction interest payment
    /// </summary>
    TRANSACTION_INTEREST_PAYMENT,

    /// <summary>
    /// Transaction internal transfer
    /// </summary>
    TRANSACTION_INTERNAL_TRANSFER,

    /// <summary>
    /// Transaction nostro deposit
    /// </summary>
    TRANSACTION_NOSTRO_DEPOSIT,

    /// <summary>
    /// Transaction on us payment in
    /// </summary>
    TRANSACTION_ON_US_PAYMENT_IN,

    /// <summary>
    /// Transaction on us payment out
    /// </summary>
    TRANSACTION_ON_US_PAYMENT_OUT,

    /// <summary>
    /// Transaction interest waived deposit
    /// </summary>
    TRANSACTION_INTEREST_WAIVED_DEPOSIT,

    /// <summary>
    /// Transaction stripe funding
    /// </summary>
    TRANSACTION_STRIPE_FUNDING,

    /// <summary>
    /// Transaction declined insufficient funds
    /// </summary>
    TRANSACTION_DECLINED_INSUFFICIENT_FUNDS,

    /// <summary>
    /// Transaction authentication declined
    /// </summary>
    TRANSACTION_AUTH_DECLINED,

    /// <summary>
    /// Transaction authentication partial reversal
    /// </summary>
    TRANSACTION_AUTH_PARTIAL_REVERSAL,

    /// <summary>
    /// Transaction authentication full reversal
    /// </summary>
    TRANSACTION_AUTH_FULL_REVERSAL
}