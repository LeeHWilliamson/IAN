using Ian.Core.Interfaces;

namespace Ian.Core.Results;

public struct AccountBalanceResult : IResult
{
    public Type ResultType => typeof(AccountBalanceResult);

    public bool Approved { get; private set; }

    public AccountBalanceResult(bool approved)
    {
        Approved = approved;
    }
}