//Handles all requests that pertain to specific users within the Ian economy (IanID, not discord or account ids)
namespace Ian.Core.Interfaces;

using System.Reflection.Metadata;
using Ian.Core.Models;
using Ian.Core.Requests;

public interface IUserService
{
    Task<bool> UserExists(ulong DiscordId); //see if DiscordId exists in users table, if so, return True
}