namespace Ian.Core.Interfaces;

public interface IUser
{
    public ulong DiscordId { get; }
    public DateTime CreatedAt { get; }
    public IPortfolio Portfolio { get; }
}