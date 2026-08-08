namespace Ian.Core.Infrastructure;

public interface IEventBus
{
    public Dictionary<Type, List<Delegate>> Subscribers { get; }
    public void Subscribe<T>(Action<T> handler);
    public void Unsubscribe<T>(Action<T> handler);
    public void Publish<T>(T eventData);
}