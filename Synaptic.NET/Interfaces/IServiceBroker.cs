namespace Synaptic.NET
{
    public interface IServiceBroker : IServiceInterCom
    {
        public string RequestID { get; set; }
        public ISynapticEndpoint Endpoint { get; set; }
    }
}
