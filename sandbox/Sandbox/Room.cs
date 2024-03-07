using System;
using System.Collections.Generic;
using System.Linq;

public class Room
{
    public string Name { get; private set; }
    private List<SmartDevice> devices = new List<SmartDevice>();

    public Room(string name)
    {
        Name = name;
    }

    public void AddDevice(SmartDevice device)
    {
        devices.Add(device);
    }

    public void ReportAllItemsStatus()
    {
        foreach (var device in devices)
        {
            Console.WriteLine(device);
        }
    }

    public void ReportItemOnLongest()
    {
        if (devices.Any(d => d.IsOn))
        {
            var longestOnDevice = devices.Where(d => d.IsOn).OrderByDescending(d => d.TimeOn()).First();
            Console.WriteLine($"{longestOnDevice.Name} has been on the longest for {longestOnDevice.TimeOn()}.");
        }
        else
        {
            Console.WriteLine("No devices are currently on.");
        }
    }

    // Additional methods
    public void TurnOnAllLights()
{
    foreach (var device in devices.OfType<SmartLight>())
    {
        device.TurnOn();
    }
}

public void TurnOffAllLights()
{
    foreach (var device in devices.OfType<SmartLight>())
    {
        device.TurnOff();
    }
}

public void TurnOnAllDevices()
{
    foreach (var device in devices)
    {
        device.TurnOn();
    }
}

public void TurnOffAllDevices()
{
    foreach (var device in devices)
    {
        device.TurnOff();
    }
}

}
