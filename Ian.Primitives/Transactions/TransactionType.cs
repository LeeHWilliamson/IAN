namespace Ian.Primitives.Transactions;

/// <summary>
/// What do these all mean?
/// </summary>
public enum TransactionType
{
    Transfer,
    Mint,
    Burn,
    Lottery,
    Reward,
    Tax,
    Confiscation,

    // if we have transfer, do we need deposit and withdraw types? A transfer implies a transfer between owned accounts while deposit and withdraw imply money flow to/from an owned account to and external source/sink...
    Deposit,
    Withdraw,
}