using Ian.Core.Interfaces;

namespace Ian.Core.Results;

public struct ActionNameResult : IResult
{
    public Type ResultType => typeof(ActionNameResult);

    public bool Approved { get; private set; }

    public ActionNameResult(bool approved)
    {
        Approved = approved;
    }
}