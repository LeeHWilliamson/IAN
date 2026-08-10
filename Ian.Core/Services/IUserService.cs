//Handles all requests that pertain to specific users within the Ian economy (IanID, not discord or account ids)
using Ian.Core.Interfaces;
using Ian.Core.Results;

namespace Ian.Core.Services;

public interface IUserService
{
    Task<bool> UserExistsAsync(ulong DiscordId); //see if DiscordId exists in users table, if so, return True

    Task AddNewUserAsync(AddUserResult addUserResult);
    Task RemoveUserAsync(ulong discordId);
    Task<IUser?> GetUserAsync(ulong discordId);
}