using System;

namespace Synaptic.NET;

public interface ISynapticService
{
    public string Name { get; }
    public int Version { get; }
    public string Description { get; }
}
