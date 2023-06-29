using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Synaptic.NET
{
    public class SynapticContext : ISynapticContext
    {
        public IServiceBroker Broker { get; set; }

        ///<summary>
        /// SynapticContext Instance Id
        ///</summary>
        public string Id { get; set; }
        
        public Dictionary<string, object> Metadata { get; set; }

        public Task Broadcast<E>(E payload) where E : ISynapticEvent
        {
            throw new NotImplementedException();
        }

        public Task Broadcast<E>(E payload, string filter) where E : ISynapticEvent
        {
            throw new NotImplementedException();
        }

        public T GetFromMetadata<T>(string key) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<ICallResponse<T>> InvokeServiceAction<T>(string versionedActionPath, SynapticServiceCallOptions callOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<ICallResponse<T>> InvokeServiceAction<T>(int version, string service, string action, SynapticServiceCallOptions callOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<ICallResponse<T>> InvokeServiceAction<T, P>(string versionedActionPath, P payload, SynapticServiceCallOptions callOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<ICallResponse<T>> InvokeServiceAction<T, P>(int version, string service, string action, P payload, SynapticServiceCallOptions callOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task Publish<E>(E payload) where E : ISynapticEvent
        {
            throw new NotImplementedException();
        }

        public Task Publish<E>(E payload, string filter) where E : ISynapticEvent
        {
            throw new NotImplementedException();
        }
    }
}
