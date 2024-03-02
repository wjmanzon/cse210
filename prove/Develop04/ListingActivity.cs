using System;

// ListingActivity is a specific kind of MindfulnessActivity focused on listing positive things.
public class ListingActivity : MindfulnessActivity
{
    // An array to hold different questions or prompts for the user.
    private string[] _listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Constructor sets the name of this activity.
    public ListingActivity()
    {
        _activityName = "Listing";
    }

    // Overrides the StartActivity method from MindfulnessActivity to include listing-specific steps.
    public override void StartActivity()
    {
        base.StartActivity(); // Calls the StartActivity method from MindfulnessActivity to do common setup tasks.
        
        // Calculate when the activity should end based on its duration.
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        // Explain what the listing activity involves.
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Thread.Sleep(3000); // Wait a bit before starting.

        Random rand = new Random(); // Used to select a random prompt.

        // Keep showing prompts until the activity's end time.
        while (DateTime.Now < endTime)
        {
            // Choose a random prompt and display it.
            string prompt = _listingPrompts[rand.Next(_listingPrompts.Length)];
            Console.WriteLine(prompt);
            Console.WriteLine();
            Countdown(3); // Give the user a moment before they need to respond.

            Console.WriteLine("Start listing your items...");

            // Count how many items the user lists.
            int itemCount = 0;
            while (DateTime.Now < endTime) // Keep accepting items until time runs out.
            {
                string input = Console.ReadLine(); // Read user input.
                if (!string.IsNullOrEmpty(input)) // If the user entered something, increase the count.
                {
                    itemCount++;
                }
                else
                {
                    // If the user didn't enter anything, assume they're done and wait for the activity to end.
                    Console.WriteLine("Item added. Press enter to add more items or wait for the activity to end.");
                    break;
                }
            }

            // After time's up, show how many items were listed.
            Console.WriteLine("Number of items listed: " + itemCount);
            if (DateTime.Now >= endTime) // If the activity's duration is over, break out of the loop.
                break;
        }

        EndActivity(); // Call the common end activity tasks from MindfulnessActivity.
    }
}
