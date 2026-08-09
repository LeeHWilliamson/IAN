namespace Ian.Core.Interfaces;

public interface IRequestHandler
{
    public IResult EvaluateRequest(IRequest request);
    public List<IResult> EvaluateRequests(List<IRequest> requests);
}