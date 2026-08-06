using Ian.Primitives.Accounts;

namespace Ian.Core.Interfaces;

public interface IAccount
{
    public Guid Id { get; }

    public ulong DiscordId { get; }

    public string AccountName { get; }

    public AccountType AccountType { get; }

    public decimal Balance { get; }

    public DateTime CreatedAt { get; }
}