using System.Collections.Generic;
using Synaptic.NET.Transport;

namespace Synaptic.NET
{
    public class SynapticOptions
    {
        public SynapticOptions() 
        { 
            Ports = new(); 
        }

        public List<uint> Ports { get; internal set; }
        public string Host { get; set; }
        
        public SynapticTransports Transport { get; set; } = SynapticTransports.Grpc;
        
        public bool EnableCaseSensitiveNaming { get; set; } = false;
        public bool AutoVersionServices { get; set; } = true;
        public bool EnforceVersionnedNaming { get; set; } = true;
        

        public void AddPort(uint port)
        {
            this.Ports.Add(port);
        }
    }
}
