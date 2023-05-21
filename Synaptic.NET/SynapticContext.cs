using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Synaptic.NET
{
    public class SynapticContext : ISynapticContext
    {
        public ServiceBroker Broker => throw new NotImplementedException();

        public SynapticEndpoint Endpoint => throw new NotImplementedException();

        public Dictionary<string, object> Metadata { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Level { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string CurrentAction => throw new NotImplementedException();

        public string CurrentEvent => throw new NotImplementedException();

        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string RequestID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ServiceBroker ISynapticContext.Broker { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        SynapticEndpoint ISynapticContext.Endpoint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task Broadcast<E>(E payload) where E : ISynapticEvent
        {
            throw new NotImplementedException();
        }

        public Task Broadcast<E>(E payload, string filter) where E : ISynapticEvent
        {
            throw new NotImplementedException();
        }

        public Task<T> InvokeServiceAction<T>(string versionedName, SynapticServiceCallOptions callOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> InvokeServiceAction<T>(string name, string version, SynapticServiceCallOptions callOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> InvokeServiceAction<T, P>(string versionedName, P payload, SynapticServiceCallOptions callOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> InvokeServiceAction<T, P>(string name, string version, P payload, SynapticServiceCallOptions callOptions = null)
        {
            throw new NotImplementedException();
        }

        public T GetFromMetaData<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public T GetFromMetadata<T>() where T : class
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
