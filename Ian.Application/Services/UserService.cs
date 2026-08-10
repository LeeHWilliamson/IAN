using Ian.Core.Interfaces;
using Ian.Core.Results;

namespace Ian.Core.Services;

public class UserService : IUserService
{

    public Task AddNewUserAsync(AddUserResult addUserResult)
    {
        throw new NotImplementedException();
    }

    public Task<IUser?> GetUserAsync(ulong discordId)
    {
        throw new NotImplementedException();
    }

    public Task RemoveUserAsync(ulong discordId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UserExistsAsync(ulong UserId)
    {
        Console.WriteLine($"Implement verifying UserExistsAsync");
        return true;
    }
}