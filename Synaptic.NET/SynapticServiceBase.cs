namespace Synaptic.NET
{
    public sealed class SynapticServiceBase
    {
        public string Name { get; }
        public uint Version { get; private set; }
        public string Description { get; private set; }

        public SynapticContext SynapticContext { get; private set; }
    }
}
