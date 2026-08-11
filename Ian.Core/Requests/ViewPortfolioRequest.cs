using Ian.Core.Interfaces;

namespace Ian.Core.Requests;

public struct ViewPortfolioRequest : IRequest
{

    public Type RequestType => typeof(ViewPortfolioRequest);
    public readonly ulong Id;
    public ViewPortfolioRequest(ulong id)
    {
        // put data needed to evaluate your request in here
        Id = id;
    }
}