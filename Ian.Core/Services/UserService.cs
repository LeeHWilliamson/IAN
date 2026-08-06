using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Models;

namespace Ian.Core.Services;

public class UserService : IUserService
{
    public async Task<bool> UserExistsAsync(ulong UserId)
    {
        Console.WriteLine($"Implement verifying UserExistsAsync");
        return true;
    }
}