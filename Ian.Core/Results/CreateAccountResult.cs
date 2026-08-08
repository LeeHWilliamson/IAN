using Ian.Core.Interfaces;

namespace Ian.Core.Results;

public struct CreateAccountResult : IResult
{
    public Type ResultType => typeof(CreateAccountResult);

    public bool Approved { get; private set; }

    public CreateAccountResult(bool approved) => Approved = approved;
}