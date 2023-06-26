namespace Synaptic.NET
{
    public class SynapticEndpoint : ISynapticEndpoint
    {
        public int Port { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Host { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Scheme { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool IsSecured { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Url { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public string GetEndpointUrl()
        {
            throw new System.NotImplementedException();
        }
    }
}
