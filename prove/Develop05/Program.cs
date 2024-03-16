using System;
using System.Collections.Generic;

class Program { 
    static void Main(string[] args) {
        // Create a user object, loading goals from "data.txt".
        User user = new User("goals.txt");
        
        string input = ""; // Variable to store user input.

        do {
            // Display the user's total score and menu options.
            Console.WriteLine($"You have {user.GetTotalScore()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Record Event");
            Console.WriteLine("  4. Exit The Program");

            // Ask for the user's choice.
            Console.Write("Your Choice: ");
            input = Console.ReadLine();
            Console.WriteLine();

            // Process the user's choice.
            switch (input) {
                case "1": // Create a new goal.
                    user.CreateGoal();
                    break;
                case "2": // List existing goals.
                    user.DisplayGoals();
                    break;
                case "3": // Mark a goal as complete.
                    user.CompleteGoal();
                    break;
            }

        // Repeat until the user chooses to exit.
        } while (new List<String>(){"1", "2", "3"}.Contains(input));

        user.WriteToFile(); // Save the user's goals to file before exiting.
        
    }
}
