using System;

public class Activity
{
    protected DateTime date;
    protected int lengthMinutes; // Length of activity in minutes

    public Activity(DateTime date, int lengthMinutes)
    {
        this.date = date;
        this.lengthMinutes = lengthMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Default implementation, should be overridden
    }

    public virtual double GetSpeed()
    {
        return 0; // Default implementation, should be overridden
    }

    public virtual double GetPace()
    {
        return 0; // Default implementation, should be overridden
    }

    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")}: Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
