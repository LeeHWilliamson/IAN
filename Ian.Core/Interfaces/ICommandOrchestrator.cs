namespace Ian.Core.Interfaces;

public interface ICommandOrchestrator
{
    public Task<string> RouteRequest(IRequest request);
    public Task<List<string>> RouteRequests(List<IRequest> requests);
}