using Ian.Core.Interfaces;

namespace Ian.Application.RequestHandling;

public class CommandOrchestrator : ICommandOrchestrator
{
    private IRequestHandler _requestHandler;
    private IResultHandler _resultHandler;
    public CommandOrchestrator(IRequestHandler requestHandler, IResultHandler resultHandler)
    {
        _requestHandler = requestHandler;
        _resultHandler = resultHandler;
    }
    public async Task<string> RouteRequest(IRequest request)
    {
        IResult result = await _requestHandler.EvaluateRequestAsync(request);
        return _resultHandler.EvaluateResult(result);
    }

    public async Task<List<string>> RouteRequests(List<IRequest> requests)
    {
        List<IResult> results = await _requestHandler.EvaluateRequestsAsync(requests);
        return _resultHandler.EvaluateResults(results);
    }
}