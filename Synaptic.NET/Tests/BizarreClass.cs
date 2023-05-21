using System;
using Synaptic.NET.Core;

namespace Synaptic.NET.Tests;


[SynapticServiceDependency("zero_servcie", Version = 1), SynapticServiceDependency("uno_srv", Version = 2)]
[SynapticServiceDependencies("v1.zero_kawa", "v3.mgmt_serv")]
public class BizarreClass : ISynapticService
{
    public string Name => "ServiceName";
    public int Version => 2;
    public string Description => "This servie sucks";

    [SynapticAction]
    public Version GetVersion()
    {
        return new Version(Version.ToString());
    }
}
