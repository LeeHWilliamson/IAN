using System.Runtime.InteropServices;
using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Results;

namespace Ian.Core.Rules;

public static class AccountBalanceRules
{
    public static AccountBalanceResult Evaluate(AccountBalanceRequest request)
    {
        // Evlaute your rules for getting the account balance, ideally everything you need to evaluate the rules are in the request

        // check that user exists

        // check that user's account exists

        Console.WriteLine($"This doesn't do anything but blindly approve requests");
        return Approved();
    }

    private static AccountBalanceResult Approved()
    {
        return new AccountBalanceResult(true);
    }

    private static AccountBalanceResult Denied()
    {
        return new AccountBalanceResult(false);
    }
}