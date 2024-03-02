using System;

// GratitudeActivity is a new type of MindfulnessActivity focused on recognizing and listing things we're grateful for.
public class GratitudeActivity : MindfulnessActivity
{
    // Constructor sets the name of this activity.
    public GratitudeActivity()
    {
        _activityName = "Gratitude";
    }

    // Overrides the StartActivity method to include gratitude-specific instructions.
    public override void StartActivity()
    {
        base.StartActivity(); // Starts with common setup tasks.
        
        // Set when this activity should end based on its duration.
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("This activity will help you focus on gratitude.");
        Console.WriteLine("Think about things you're thankful for in your life.");

        // Keep asking the user to list things they're grateful for until the activity's end time.
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nWhat's one thing you're grateful for?\n");
            Countdown(_duration/2);
            Console.WriteLine("Think about why you are grateful for this person or thing...\n");
            Countdown(_duration/2); // Give time for reflection or writing another item.
        }

        EndActivity(); // Concludes the activity.
    }
}
