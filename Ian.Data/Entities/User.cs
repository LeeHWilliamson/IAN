using System.Dynamic;

public class User
{
    public Guid UserId { get; set; }

    public ulong DiscordId { get; set; }

    public decimal Debt { get; set; }

    public DateTime CreatedAt { get; set; }
}