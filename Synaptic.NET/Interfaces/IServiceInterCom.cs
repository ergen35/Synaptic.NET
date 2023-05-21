using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Synaptic.NET
{
    public interface IServiceInterCom
    {
        public Dictionary<string, object> Metadata { get; set; }

        public T GetFromMetadata<T>(string key) where T : class;

        public Task<ICallResponse<T>> InvokeServiceAction<T>(string versionedActionPath, SynapticServiceCallOptions callOptions = null);
        public Task<ICallResponse<T>> InvokeServiceAction<T>(int version, string service, string action, SynapticServiceCallOptions callOptions = null);
        // Call with payload
        public Task<ICallResponse<T>> InvokeServiceAction<T, P>(string versionedActionPath, P payload, SynapticServiceCallOptions callOptions = null);
        public Task<ICallResponse<T>> InvokeServiceAction<T, P>(int version, string service, string action, P payload, SynapticServiceCallOptions callOptions = null);



        //Events
        public Task Publish<E>(E payload) where E : ISynapticEvent;
        public Task Broadcast<E>(E payload) where E : ISynapticEvent;

        // allow filtering receivers
        [Obsolete] public Task Publish<E>(E payload, string filter) where E : ISynapticEvent;
        [Obsolete] public Task Broadcast<E>(E payload, string filter) where E : ISynapticEvent;
    }
}
