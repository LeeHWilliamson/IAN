using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Results;
using Ian.Core.Services;

namespace Ian.Core.Rules;

public static class AddUserRules
{
    public static async Task<AddUserResult> Evaluate(AddUserRequest request, IUserService userService)
    {
        // Evlaute your rules
        bool res = await userService.UserExistsAsync(request.DiscordId);
        Console.WriteLine($"[AddUserRules] user exits: {res}");
        if (!res)
        {
            return Approved(request);
        }
        return Denied(request);
    }

    private static AddUserResult Approved(AddUserRequest request)
    {
        return new AddUserResult(true, request.DiscordId);
    }

    private static AddUserResult Denied(AddUserRequest request)
    {
        return new AddUserResult(false, request.DiscordId);
    }
}