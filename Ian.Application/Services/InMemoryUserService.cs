using System.Data;
using Ian.Core.Interfaces;
using Ian.Core.Results;
using Ian.Core.Services;
using Ian.Data.Entities;

namespace Ian.Application.Services;

public class InMemoryUserService : IUserService
{
    private Dictionary<ulong, IUser> _users = new();

    public Task AddNewUserAsync(AddUserResult result)
    {
        IUser newUser = new User(result.DiscordId);
        // if you fail to add the new user
        if (!_users.TryAdd<ulong, IUser>(result.DiscordId, newUser))
        {
            // throw an error
            throw new DataException($"User with id {result.DiscordId} already exists in the table.");
        }
        return Task.CompletedTask;
    }

    public Task<IUser?> GetUserAsync(ulong discordId)
    {
        _users.TryGetValue(discordId, out IUser? user);

        return Task.FromResult(user);
    }

    public Task RemoveUserAsync(ulong discordId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UserExistsAsync(ulong DiscordId)
    {
        return Task.FromResult(_users.ContainsKey(DiscordId));
    }
}