using Ian.Core.Interfaces;

namespace Ian.Core.Results;

public struct GetTransactionHistoryResult : IResult
{
    public Type ResultType => typeof(GetTransactionHistoryResult);

    public bool Approved { get; private set; }

    public GetTransactionHistoryResult(bool approved) => Approved = approved;
}