namespace Ian.Core.Interfaces;

public interface IRequestHandler
{
    public Task<IResult> EvaluateRequestAsync(IRequest request);
    public Task<List<IResult>> EvaluateRequestsAsync(List<IRequest> requests);
}