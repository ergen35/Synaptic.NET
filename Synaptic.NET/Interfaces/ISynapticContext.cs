using System.Collections.Generic;

namespace Synaptic.NET;

public interface ISynapticContext
{
    public string Id { get; set; }
    public IServiceBroker Broker { get; set; }

    public Dictionary<string, string> Metadata { get; set; }
    public string GetFromMetadata(string key);
}
