using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Synaptic.NET.Tests;


[SynapticServiceDependencies("users_mgmt", "mgmt_serv")]
public class BizarreClass : ISynapticService
{
    private readonly ISynapticContext ctx;

    public string Name => "ServiceName";
    public uint Version => 2;

    public BizarreClass(ISynapticContext ctx)
    {
        this.ctx = ctx;
    }

    //This is an Action
    [SynapticAction]
    [HttpGet("battery-level")]
    [Authorize(Policy = "battery-level:read")]
    public double GetBatteryLife()
    {
        return Random.Shared.Next(maxValue: 100, minValue: 0) * Random.Shared.NextDouble();
    }

    //This is an event handler
    [SynapticEventHandler]
    public void OnBizarreAction(BatteryFullEvent EventData)
    {
        Console.WriteLine("Processing event: {0}", EventData.EventName);
    }


    //This is a private method that'll not get exposed
    private void MyMethod()
    {
        //do some random stuff there
    }
}
