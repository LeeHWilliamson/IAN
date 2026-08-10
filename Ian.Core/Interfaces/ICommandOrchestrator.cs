namespace Ian.Core.Interfaces;

public interface ICommandOrchestrator
{
    public string RouteRequest(IRequest request);
    public List<string> RouteRequests(List<IRequest> requests);
}