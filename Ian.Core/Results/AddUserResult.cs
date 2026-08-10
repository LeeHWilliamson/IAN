using Ian.Core.Interfaces;

namespace Ian.Core.Results;

public struct AddUserResult : IResult
{
    public Type ResultType => typeof(AddUserResult);

    public bool Approved { get; private set; }
    public readonly ulong DiscordId;
    public AddUserResult(bool approved, ulong discordId)
    {
        Approved = approved;
        DiscordId = discordId;
    }
}