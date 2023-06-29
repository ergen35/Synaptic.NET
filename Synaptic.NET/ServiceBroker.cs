using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Synaptic.NET
{
    public class ServiceBroker : IServiceBroker
    {
        public ISynapticEndpoint Endpoint { get; }
        
        //TODO: Add bus access to be able to publish requests and events

        public ServiceBroker(ISynapticEndpoint endpoint)
        {
            Endpoint = endpoint;
        }

        public Task Broadcast<E>(E payload) where E : ISynapticEvent
        {
            throw new NotImplementedException();
        }

        public Task Broadcast<E>(E payload, string filter) where E : ISynapticEvent
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

        public Task<ICallResponse<T>> InvokeActionAsync<T>(string versionedActionPath, SynapticServiceCallOptions callOptions)
        {
            throw new NotImplementedException();
        }

        public Task<ICallResponse<T>> InvokeActionAsync<T>(uint version, string service, string action, SynapticServiceCallOptions callOptions)
        {
            throw new NotImplementedException();
        }

        public Task<ICallResponse<T>> InvokeActionAsync<T, P>(string versionedActionPath, P payload, SynapticServiceCallOptions callOptions)
        {
            throw new NotImplementedException();
        }

        public Task<ICallResponse<T>> InvokeActionAsync<T, P>(uint version, string service, string action, P payload, SynapticServiceCallOptions callOptions)
        {
            throw new NotImplementedException();
        }
    }
}
