using System.Dynamic;
using Ian.Core.Interfaces;

public class User
{
    public Guid UserId { get; set; }

    public ulong DiscordId { get; set; }

    public decimal Debt { get; set; }

    public DateTime CreatedAt { get; set; }

    public IPortfolio Portfolio { get; private set; }
}