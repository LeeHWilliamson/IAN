
using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Ian.Application.Services;

public class UserService : IUserService
{
    private readonly IanContext _context; 

    public UserService(IanContext context)
    {
        _context = context;
    }
    public async Task<User?> CreateUser(ulong DiscordId)
    {
        if (await UserExistsAsync(DiscordId))
        {
            return null;
        }
        var user = new User();
        {
        user.UserId = Guid.NewGuid();
        user.DiscordId = DiscordId;
        user.Debt = 0;
        user.CreatedAt = DateTime.UtcNow;
        };

        _context.Users.Add(user);

        await _context.SaveChangesAsync();
        return user;
    }
    public async Task<bool> UserExistsAsync(ulong DiscordId)
    {
        return await _context.Users
            .AnyAsync(user => user.DiscordId == DiscordId);
    }
}