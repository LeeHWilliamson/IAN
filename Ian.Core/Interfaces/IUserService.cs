//Handles all requests that pertain to specific users within the Ian economy (IanID, not discord or account ids)
namespace Ian.Core.Interfaces;

public interface IUserService
{
    Task<bool> UserExistsAsync(ulong DiscordId); //see if DiscordId exists in users table, if so, return True
}