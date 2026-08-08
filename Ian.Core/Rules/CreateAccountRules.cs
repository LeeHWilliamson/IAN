using Ian.Core.Requests;
using Ian.Core.Results;

namespace Ian.Core.Rules;

public class CreateAccountRules
{
    public static CreateAccountResult Evaluate(CreateAccountRequest request)
    {
        // Evlaute your rules for getting the account balance, ideally everything you need to evaluate the rules are in the request

        // check that user exists

        // check that user's account exists

        Console.WriteLine($"This doesn't do anything but blindly approve requests");
        return Approved();
    }

    private static CreateAccountResult Approved()
    {
        return new CreateAccountResult(true);
    }

    private static CreateAccountResult Denied()
    {
        return new CreateAccountResult(false);
    }
}