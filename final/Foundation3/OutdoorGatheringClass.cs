using System;

public class OutdoorGatheringClass : Event
{
    public string Weather { get; set; }

    public OutdoorGatheringClass(string title, string description, DateTime date, TimeSpan time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        Weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()} Weather forecast: {Weather}";
    }
}
