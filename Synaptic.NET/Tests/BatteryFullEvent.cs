namespace Synaptic.NET.Tests
{
    public class BatteryFullEvent : ISynapticEvent
    {
        public string EventName => typeof(BatteryFullEvent).Name;
    }
}
