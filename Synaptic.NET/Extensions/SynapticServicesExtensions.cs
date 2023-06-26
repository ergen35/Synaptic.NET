using System;
using System.Reflection;
using Synaptic.NET;

namespace Microsoft.Extensions.DependencyInjection;

public interface ISynapticBuilder: IServiceCollection{}


public static class SynapticNetServicesExtensions
{
    public static ISynapticBuilder AddSynapticNet(this IServiceCollection services, Action<SynapticOptions> options)
    {
        throw new NotImplementedException();
    }

    public static ISynapticBuilder AddServer(this ISynapticBuilder builder, uint port)
    {
        throw new NotImplementedException();
    }
    
    public static ISynapticBuilder AddSynapticService<T>(this ISynapticBuilder builder) where T: ISynapticService
    {
        throw new NotImplementedException();
    }

    public static ISynapticBuilder AddServicesFromAssembly(this ISynapticBuilder builder, Assembly assembly)
    {
        throw new NotImplementedException();
    }

    public static ISynapticBuilder AddServicesFromAssemblies(this ISynapticBuilder builder, params Assembly[] assemblies)
    {
        throw new NotImplementedException();
    }
}
