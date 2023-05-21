namespace Synaptic.NET
{
    public interface IServiceBroker : IServiceInterCom
    {
        public string RequestID { get; set; }
        public SynapticEndpoint Endpoint { get; set; }
    }
}
