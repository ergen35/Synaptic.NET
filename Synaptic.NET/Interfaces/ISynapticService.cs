namespace Synaptic.NET;

public interface ISynapticService
{
    public abstract string Name { get; }
    public abstract uint Version { get; }
    public virtual string Description => string.Empty;
}
