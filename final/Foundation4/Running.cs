using System;

public class Running : Activity
{
    private double distance; // in miles

    public Running(DateTime date, int lengthMinutes, double distance) : base(date, lengthMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / lengthMinutes) * 60;
    }

    public override double GetPace()
    {
        return lengthMinutes / distance;
    }
}
