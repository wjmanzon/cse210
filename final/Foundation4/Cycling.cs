using System;

public class Cycling : Activity
{
    private double speed; // in mph

    public Cycling(DateTime date, int lengthMinutes, double speed) : base(date, lengthMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed * lengthMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }
}
