using System.Threading.Tasks;

namespace Synaptic.NET
{
    public interface IServiceBroker
    {
        public ISynapticEndpoint Endpoint { get; }

        
        public Task<ICallResponse<T>> InvokeActionAsync<T>(string versionedActionPath, SynapticServiceCallOptions callOptions = null);
        public Task<ICallResponse<T>> InvokeActionAsync<T>(uint version, string service, string action, SynapticServiceCallOptions callOptions = null);
        
        // Call with payload
        public Task<ICallResponse<T>> InvokeActionAsync<T, P>(string versionedActionPath, P payload, SynapticServiceCallOptions callOptions = null);
        public Task<ICallResponse<T>> InvokeActionAsync<T, P>(uint version, string service, string action, P payload, SynapticServiceCallOptions callOptions = null);

        //Events
        public Task Publish<E>(E payload) where E : ISynapticEvent;
        public Task Publish<E>(E payload, string filter) where E : ISynapticEvent;
        public Task Broadcast<E>(E payload) where E : ISynapticEvent;
        public Task Broadcast<E>(E payload, string filter) where E : ISynapticEvent;
    }
}
