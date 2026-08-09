using Ian.Core.Interfaces;
using Ian.Core.Requests;
using Ian.Core.Results;

namespace Ian.Core.Rules;

public static class TestRules
{
    public static TestResult Evaluate(TestRequest request)
    {
        // Evlaute your rules

        Console.WriteLine($"This doesn't do anything but blindly approve Test requests");
        return Approved();
    }

    private static TestResult Approved()
    {
        return new TestResult(true);
    }

    private static TestResult Denied()
    {
        return new TestResult(false);
    }
}