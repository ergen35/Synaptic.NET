using System;

namespace Synaptic.NET;

[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
sealed class SynapticServiceDependenciesAttribute : Attribute
{
    readonly string[] serviceDependencies;

    public SynapticServiceDependenciesAttribute(params string[] services)
    {
        this.serviceDependencies = services;
        throw new System.NotImplementedException();
    }

    public string[] ServiceDependencies
    {
        get { return serviceDependencies; }
    }

}
