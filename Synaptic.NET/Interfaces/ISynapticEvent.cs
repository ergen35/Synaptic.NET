namespace Synaptic.NET;

public interface ISynapticEvent<T>: ISynapticEvent
{
    public T Payload { get; set; }
}

public interface ISynapticEvent
{
    public string EventName { get; }
    public long TimeStamp { get; set; }
}

