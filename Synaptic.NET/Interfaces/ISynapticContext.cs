using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Synaptic.NET;

public interface ISynapticContext: IServiceInterCom
{
    public int Level { get; set; }
    public ServiceBroker Broker { get; set; }

    public string? CurrentAction { get; }
    public string? CurrentEvent { get; }
    public string Id { get; set; }

}
