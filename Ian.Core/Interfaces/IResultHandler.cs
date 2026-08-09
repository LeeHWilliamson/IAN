namespace Ian.Core.Interfaces;

public interface IResultHandler
{
    public string EvaluateResult(IResult result);
    public List<string> EvaluateResults(List<IResult> results);
}