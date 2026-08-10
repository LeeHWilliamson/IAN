using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Results;
using Ian.Core.Services;

namespace Ian.Core.Rules;

public class CreateAccountRules
{
    public static async Task<CreateAccountResult> Evaluate(CreateAccountRequest request, IUserService userService, IAccountService accountService)
    {
        // Evaluate rules to make an account
        Console.WriteLine($"Evaluating Create Account Rules");
        // does the user exist?
        bool userExists = await userService.UserExistsAsync(request.RequesterId);
        if (!userExists) return Denied(request);
        Console.WriteLine($"User exists");

        // is the name unique
        IUser user = await userService.GetUserAsync(request.RequesterId);
        if (user != null)
        {
            if (user.Portfolio.Accounts.ContainsKey(request.AccountName))
            {
                return Denied(request);
            }
        }
        Console.WriteLine($"Account name was unique");
        // does the user have permission to make this account type?
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Implement verifying account permissions");
        Console.ResetColor();

        // Console.WriteLine($"This doesn't do anything but blindly approve requests");
        return Approved(request);
    }

    private static CreateAccountResult Approved(CreateAccountRequest request)
    {
        return new CreateAccountResult(true, request.RequesterId, request.AccountName, request.AccountType);
    }

    private static CreateAccountResult Denied(CreateAccountRequest request)
    {
        return new CreateAccountResult(false, request.RequesterId, request.AccountName, request.AccountType);
    }
}