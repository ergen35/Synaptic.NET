using System;

namespace Synaptic.NET;

[AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
sealed class SynapticEventHandlerAttribute : Attribute
{
    public SynapticEventHandlerAttribute()
    {
        // TODO: Implement code here
        throw new System.NotImplementedException();
    }
}