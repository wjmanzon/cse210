using System;

public abstract class SmartDevice
{
    public string Name { get; private set; }
    public bool IsOn { get; private set; }
    private DateTime? TurnedOnAt { get; set; }

    protected SmartDevice(string name)
    {
        Name = name;
    }

    public void TurnOn()
    {
        IsOn = true;
        TurnedOnAt = DateTime.Now;
    }

    public void TurnOff()
    {
        IsOn = false;
        TurnedOnAt = null;
    }

    public TimeSpan TimeOn()
    {
        if (IsOn && TurnedOnAt.HasValue)
        {
            return DateTime.Now - TurnedOnAt.Value;
        }
        return TimeSpan.Zero;
    }

    public override string ToString()
    {
        return $"{Name} is {(IsOn ? "on" : "off")}, on for {TimeOn()}";
    }
}
