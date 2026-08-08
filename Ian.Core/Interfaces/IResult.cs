namespace Ian.Core.Interfaces;

public interface IResult
{
    public Type ResultType { get; }
    public bool Approved { get; }
}