// Include necessary namespaces for the program to run.
using System;

// Define a class named Program. This is the main class where our program starts.
class Program
{
    // The entry point of our application. The Main method is where the program begins execution.
    static void Main(string[] args)
    {
        // Declare a variable to store the user's choice.
        int choice;
        
        // Use a do-while loop to keep showing the menu until the user decides to exit.
        do
        {
            // Display a menu of activities to the user.
           Console.WriteLine(@"Select an activity:
    1. Breathing Activity
    2. Reflection Activity
    3. Listing Activity
    4. Gratitude Activity
    5. Exit");

            // Read the user's choice from the console and convert it to an integer.
            choice = int.Parse(Console.ReadLine());

            // Declare a variable of type MindfullnessActivity. This will be used to hold the specific activity chosen by the user.
            MindfulnessActivity activity;

            // Use if-else statements to determine which activity the user has chosen.
            if (choice == 1)
            {
                // If the choice is 1, create a new BreathingActivity and start it.
                activity = new BreathingActivity();
                activity.StartActivity();
            }
            else if (choice == 2)
            {
                // If the choice is 2, create a new ReflectionActivity and start it.
                activity = new ReflectionActivity();
                activity.StartActivity();
            }
            else if (choice == 3)
            {
                // If the choice is 3, create a new ListingActivity and start it.
                activity = new ListingActivity();
                activity.StartActivity();
            }
            else if (choice == 4)
            {
                // If the choice is 4, create a new GratitudeActivity and start it.
                activity = new GratitudeActivity();
                activity.StartActivity();
            }
            else if (choice == 5)
            {
                // If the choice is 5, print a thank you message for using the program.
                Console.WriteLine("Thanks for using Mindfulness Activity program!");
            }
            else
            {
                // If the user enters an invalid choice, display an error message.
                Console.WriteLine("Please choose a valid option.");
            }

        } while (choice != 5); // Continue showing the menu until the user selects option 4 to exit.
    }
}
