using System;

// Defines a breathing exercise as a specific type of mindfulness activity.
public class BreathingActivity : MindfulnessActivity
{
    // Sets the activity's name in the constructor.
    public BreathingActivity()
    {
        _activityName = "Breathing";
    }

    // Customizes the activity's beginning with specific steps for breathing exercises.
    public override void StartActivity()
    {
        base.StartActivity(); // Calls the base method for common setup tasks.
        
        // Calculates when the activity should end based on the duration.
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("This activity will guide you through breathing exercises Clear your mind and focus on your breath.");

        // Loop to continue the breathing exercises until the set end time.
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... \n"); 
            Countdown(6); // Countdown for 6 seconds during the inhale.
            Console.Write("\nBreathe out... \n");
            Countdown(4); // Countdown for 4 seconds during the exhale.
            Console.WriteLine();
        }

        EndActivity(); // Call the base method to conclude the activity.
    }
}
