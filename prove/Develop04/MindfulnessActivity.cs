using System;

public class MindfulnessActivity
{
    protected int _duration; // Duration of the activity in seconds
    protected string _activityName; // Name of the activity

    // Simplifies starting the activity by combining prompts and reducing the pause time for quicker testing or demonstration.
    public virtual void StartActivity()
    {
        Console.Clear();
        ShowSpinner();
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity!\nThis activity will help you focus and relax.");
        Console.Write("Please enter the duration in seconds: ");
        _duration = int.TryParse(Console.ReadLine(), out int result) ? result : 30; // Provides a default duration if input is invalid
        Console.WriteLine("Get ready to start...");
        Thread.Sleep(3000); // Reduced pause time for quicker start
    }

    // Combines the end activity message and uses a shorter pause.
    public virtual void EndActivity()
    {
        Console.WriteLine($"\nGreat job! You've completed the {_activityName} activity for {_duration} seconds.");
        Thread.Sleep(3000); // Shorter pause for reflection
    }

    // Streamlines the spinner for simplicity and readability.
    static void ShowSpinner()
    {
        foreach (var c in new[] { "-", "\\", "|", "/" })
        {
            Console.Write($"{c}\r");
            Thread.Sleep(200); // Speeds up the spinner for quicker feedback
        }
    }

    // Simplifies the countdown timer logic for clarity.
    public void Countdown(int seconds)
    {
        while (seconds-- > 0)
        {
            Console.Write($"\r{seconds + 1} "); // Shows the countdown with a space to overwrite previous output cleanly
            Thread.Sleep(1000);
        }
        Console.Write("\r  \r"); // Clears the last output more reliably
    }
}
