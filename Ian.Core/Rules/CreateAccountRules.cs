using Ian.Core.Requests;
using Ian.Core.Results;

namespace Ian.Core.Rules;

public class CreateAccountRules
{
    public static CreateAccountResult Evaluate(CreateAccountRequest request)
    {
        // Evaluate rules to make an account

        // is the name unique

        // does the user have permission to make this account type?

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