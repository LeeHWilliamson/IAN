using System.Dynamic;
using Ian.Core.Interfaces;

namespace Ian.Data.Entities;

public class User : IUser
{
    // public Guid UserId { get; set; }

    public ulong DiscordId { get; private set; }

    // public decimal Debt { get; set; }

    public DateTime CreatedAt { get; private set; }

    public IPortfolio Portfolio { get; private set; }

    public User(ulong id)
    {
        DiscordId = id;
        CreatedAt = DateTime.Now;
        Portfolio = new Portfolio();
    }
}