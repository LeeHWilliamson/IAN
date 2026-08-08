using Ian.Core.Infrastructure;
using Serilog;

namespace Infrastructure.Application.EventBus
{
    public class EventBus : IEventBus
    {
        public Dictionary<Type, List<Delegate>> Subscribers => _subscribers;
        private Dictionary<Type, List<Delegate>> _subscribers = new();

        private bool _debugEvents = false;

        public void Publish<T>(T eventData)
        {
            var eventType = typeof(T);

            if (!_subscribers.TryGetValue(eventType, out var delegates))
            {
                Log.Warning($"No subscribers found for {eventType}");
                return;
            }
            foreach (var handler in delegates)
            {
                ((Action<T>)handler).Invoke(eventData);
                if (_debugEvents) Log.Information($"Raising event {eventData} for {handler}");
            }
        }

        public void Subscribe<T>(Action<T> handler)
        {
            var handlerType = typeof(T);

            if (!_subscribers.TryGetValue(handlerType, out var delegates))
            {
                delegates = new List<Delegate>();
                _subscribers[handlerType] = delegates;
            }
            if (_debugEvents) Log.Information($"Subscribed {handler} for {handlerType}");
            delegates.Add(handler);
        }

        public void Unsubscribe<T>(Action<T> handler)
        {
            var handlerType = typeof(T);

            if (_subscribers.TryGetValue(handlerType, out var delegates))
            {
                delegates.Remove(handler);
                if (_debugEvents) Log.Information($"Unsubscribed {handler} for {handlerType}");
            }
        }
    }
}