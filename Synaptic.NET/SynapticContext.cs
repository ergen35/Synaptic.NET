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
        
        public Dictionary<string, string> Metadata { get; set; } = new();

        public Task Broadcast<E>(E payload) where E : ISynapticEvent
        {
            throw new NotImplementedException();
        }

        public Task Broadcast<E>(E payload, string filter) where E : ISynapticEvent
        {
            throw new NotImplementedException();
        }

        public string GetFromMetadata(string key)
        {
            ArgumentException.ThrowIfNullOrEmpty(key);

            if(this.Metadata.ContainsKey(key)) 
                return Metadata[key];
            else 
                throw new KeyNotFoundException($"Unable to find the {key} in the Context Metadata.");
        }
    }
}
