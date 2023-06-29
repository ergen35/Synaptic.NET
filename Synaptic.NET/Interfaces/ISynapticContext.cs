namespace Synaptic.NET;

public interface ISynapticContext : IServiceInterCom
{
    public string Id { get; set; }
    public IServiceBroker Broker { get; set; }
}
