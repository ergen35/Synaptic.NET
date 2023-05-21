using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synaptic.NET
{
    public interface IServiceBroker: IServiceInterCom
    {
        public string RequestID { get; set; }
        public SynapticEndpoint Endpoint { get; set; }
    }
}
