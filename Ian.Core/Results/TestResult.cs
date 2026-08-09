using Ian.Core.Interfaces;

namespace Ian.Core.Results;

public struct TestResult : IResult
{
    public Type ResultType => typeof(TestResult);

    public bool Approved { get; private set; }

    public TestResult(bool approved)
    {
        Approved = approved;
    }
}