namespace Ian.Primitives.Accounts;

public enum AccountType
{
    Peasant,
    RichKing,
    EldenLord,

    Checking,
    Savings,
    HighYield,
}

public static class AccountTypeExtensions
{
    public static decimal GetInterestRate(this AccountType type) => type switch
    {
        AccountType.Peasant => 0.001m, // 0.1%
        AccountType.RichKing => 0.005m, // 0.5%
        AccountType.EldenLord => 0.01m, // 1%
        AccountType.Checking => 0.0m, // 0%
        AccountType.Savings => 0.02m, // 2%
        AccountType.HighYield => 0.045m, // 4.5%
        _ => throw new ArgumentOutOfRangeException(nameof(type))
    };
}