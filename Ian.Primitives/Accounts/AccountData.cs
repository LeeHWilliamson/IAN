namespace Ian.Primitives.Accounts;

public struct AccountData : IAccountData
{
    public ulong DiscordId { get; private set; }

    public string AccountName { get; private set; }

    public AccountType AccountType { get; private set; }

    public decimal Balance { get; private set; }

    public decimal BaseInterestRate { get; private set; }

    public AccountData(ulong discordId, string accountName, AccountType accountType)
    {
        DiscordId = discordId;
        AccountName = accountName;
        AccountType = accountType;
        // Assuming a new account
        Balance = 0;

    }
}