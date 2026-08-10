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
    public string RouteRequest(IRequest request)
    {
        IResult result = _requestHandler.EvaluateRequest(request);
        return _resultHandler.EvaluateResult(result);
    }

    public List<string> RouteRequests(List<IRequest> requests)
    {
        List<IResult> results = _requestHandler.EvaluateRequests(requests);
        return _resultHandler.EvaluateResults(results);
    }
}