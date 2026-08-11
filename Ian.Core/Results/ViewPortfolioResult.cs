using Ian.Core.Interfaces;

namespace Ian.Core.Results;

public struct ViewPortfolioResult : IResult
{
    public Type ResultType => typeof(ViewPortfolioResult);

    public bool Approved { get; private set; }
    public readonly ulong Id;

    public ViewPortfolioResult(bool approved, ulong id)
    {
        Approved = approved;
        Id = id;
    }
}