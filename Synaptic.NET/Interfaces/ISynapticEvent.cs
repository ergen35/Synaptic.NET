namespace Synaptic.NET;

public interface ISynapticEvent<T>
{
    public string EventName { get; }
    public T Payload { get; set; }
}

public interface ISynapticEvent
{
    public string EventName { get; }
}

