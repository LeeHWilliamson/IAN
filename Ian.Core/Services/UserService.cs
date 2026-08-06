using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Models;

namespace Ian.Core.Services;

public class UserService : IUserService
{    public Task<bool> UserExists(ulong UserId)
    {
        throw new NotImplementedException();
    }
}