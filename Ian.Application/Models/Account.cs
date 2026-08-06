using Ian.Core.Interfaces;
using Ian.Primitives.Accounts;

namespace Ian.Core.Models;

public class Account : IAccount
{
    public Guid Id { get; set; }

    public ulong DiscordId { get; set; }

    public string AccountName { get; set; } = "";

    public AccountType AccountType { get; set; } = AccountType.Peasant;

    public decimal Balance { get; set; }

    public DateTime CreatedAt { get; set; }
}