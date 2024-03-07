using System;

class Device
{
    public bool IsOn { get; private set; }
    private DateTime? turnedOnAt;
    public string Name { get; private set; }

    public Device(string name)
    {
        IsOn = false;
        Name = name;
    }

    public void Toggle()
    {
        if (IsOn)
        {
            IsOn = false;
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"{Name} is now off.");
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
        }
        else
        {
            IsOn = true;
            turnedOnAt = DateTime.Now;
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"{Name} is now on");
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
        }
    }

    public TimeSpan? GetOnDuration()
    {
        if (IsOn && turnedOnAt.HasValue)
        {
            return DateTime.Now - turnedOnAt.Value;
        }
        return null;
    }
}
