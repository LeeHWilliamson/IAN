using Ian.Core.Requests;
using Ian.Core.Results;

namespace Ian.Core.Rules;

public class TransferRules
{
    public static TransferResult Evaluate(TransferRequest request)
    {
        // Evlaute your rules for getting the account balance, ideally everything you need to evaluate the rules are in the request

        // check that user exists

        // check that user's account exists

        Console.WriteLine($"This doesn't do anything but blindly approve requests");
        return Approved();
    }

    private static TransferResult Approved()
    {
        return new TransferResult(true);
    }

    private static TransferResult Denied()
    {
        return new TransferResult(false);
    }
}