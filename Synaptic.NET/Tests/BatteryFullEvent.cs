using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Synaptic.NET;

namespace Synaptic.NET.Tests
{
    public class BatteryFullEvent: ISynapticEvent
    {
        public string EventName => typeof(BatteryFullEvent).Name;
    }
}
