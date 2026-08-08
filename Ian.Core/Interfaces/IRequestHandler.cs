namespace Ian.Core.Interfaces;

public interface IRequestHandler
{
    public List<IResult> EvaluateRequests(List<IRequest> requests);
}