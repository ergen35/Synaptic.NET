using System;

namespace Synaptic.NET;


[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
sealed class SynapticServiceDependencyAttribute : Attribute
{
    readonly string name;
    
    public SynapticServiceDependencyAttribute(string name)
    {
        this.name = name;
        
        // TODO: Implement code here
        throw new System.NotImplementedException();
    }
    
    public string Name
    {
        get { return name; }
    }
    
    // This is a named argument
    public int Version { get; set; }
}