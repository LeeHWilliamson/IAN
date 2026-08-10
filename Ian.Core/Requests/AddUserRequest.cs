using Ian.Core.Interfaces;

namespace Ian.Core.Requests;

public struct AddUserRequest : IRequest
{

    public Type RequestType => typeof(AddUserRequest);
    public readonly ulong DiscordId;
    public AddUserRequest(ulong discordId)
    {
        DiscordId = discordId;
    }
}