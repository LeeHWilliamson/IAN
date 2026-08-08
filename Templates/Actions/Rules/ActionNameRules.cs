using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Results;

namespace Ian.Core.Rules;

public static class ActionNameRules
{
    public static ActionNameResult Evaluate(ActionNameRequest request)
    {
        // Evlaute your rules

        Console.WriteLine($"This doesn't do anything but blindly approve ActionName requests");
        return Approved();
    }

    private static ActionNameResult Approved()
    {
        return new ActionNameResult(true);
    }

    private static ActionNameResult Denied()
    {
        return new ActionNameResult(false);
    }
}