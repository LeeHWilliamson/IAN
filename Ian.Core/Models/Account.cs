namespace Ian.Core.Models;

public class Account
{
    public Guid Id { get; set; }

    public ulong DiscordId { get; set; }

    public string AccountName { get; set; } = "";

    public string AccountType { get; set; } = "Peasant";

    public decimal Balance { get; set; }

    public DateTime CreatedAt { get; set; }
}