using Ian.Core.Interfaces;

namespace Ian.Core.Results;

public struct TransferResult : IResult
{
    public Type ResultType => typeof(TransferResult);

    public bool Approved { get; private set; }

    public TransferResult(bool approved) => Approved = approved;
}