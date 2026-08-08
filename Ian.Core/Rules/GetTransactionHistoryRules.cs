using Ian.Core.Requests;
using Ian.Core.Results;

namespace Ian.Core.Rules;

public static class GetTransactionHistoryRules
{
    public static GetTransactionHistoryResult Evaluate(GetTransactionHistoryRequest request)
    {
        // Evlaute your rules for getting the account balance, ideally everything you need to evaluate the rules are in the request

        // check that user exists

        // check that user's account exists

        Console.WriteLine($"This doesn't do anything but blindly approve requests");
        return Approved();
    }

    private static GetTransactionHistoryResult Approved()
    {
        return new GetTransactionHistoryResult(true);
    }

    private static GetTransactionHistoryResult Denied()
    {
        return new GetTransactionHistoryResult(false);
    }
}