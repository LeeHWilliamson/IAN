using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Results;
using Ian.Core.Services;

namespace Ian.Core.Rules;

public static class ViewPortfolioRules
{
    public async static Task<ViewPortfolioResult> Evaluate(ViewPortfolioRequest request, IUserService userService, IAccountService accountService)
    {
        // Does the user exist?
        bool res = await userService.UserExistsAsync(request.Id);
        Console.WriteLine($"[AddUserRules] user exits: {res}");
        if (!res)
        {
            return Denied(request);
        }
        // Does the user have any accounts?
        IUser user = await userService.GetUserAsync(request.Id);
        if (user.Portfolio == null) return Denied(request);

        return Approved(request);
    }

    private static ViewPortfolioResult Approved(ViewPortfolioRequest request)
    {
        return new ViewPortfolioResult(true, request.Id);
    }

    private static ViewPortfolioResult Denied(ViewPortfolioRequest request)
    {
        return new ViewPortfolioResult(false, request.Id);
    }
}