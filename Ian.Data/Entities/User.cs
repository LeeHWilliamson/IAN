public class User
{
    public Guid Id { get; set; }

    public ulong DiscordId { get; set; }

    public string DisplayName { get; set; } = "";

    public decimal Balance { get; set; }

    public DateTime CreatedAt { get; set; }
}