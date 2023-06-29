namespace Synaptic.NET
{
    public interface ISynapticEndpoint
    {
        public int Port { get; set; }
        public string Host { get; set; }
        public string Scheme { get; set; }
        public bool IsSecured { get; set; }
        public string Url { get; set; }

        public string GetEndpointUrl();
    }
}
