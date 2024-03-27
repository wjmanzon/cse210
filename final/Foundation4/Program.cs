using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Activity Tracker\n");
        while (true)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Please choose an activity by entering the corresponding number:");
            Console.WriteLine("1. Running");
            Console.WriteLine("2. Cycling");
            Console.WriteLine("3. Swimming");
            Console.WriteLine("Type 'quit' to exit.");
            Console.WriteLine("-------------------------------------------");

            string input = Console.ReadLine();
            if (input.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Exiting program...\n");
                break;
            }

            if (!int.TryParse(input, out int choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("\nInvalid choice. Please enter a number between 1 and 3, or type 'quit' to exit.\n");
                continue;
            }

            Console.WriteLine("\nEnter the duration of the activity in minutes:");
            if (!int.TryParse(Console.ReadLine(), out int durationMinutes) || durationMinutes <= 0)
            {
                Console.WriteLine("\nInvalid duration. Please enter a positive number.\n");
                continue;
            }

            Activity selectedActivity = null;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nEnter distance in miles:");
                    if (double.TryParse(Console.ReadLine(), out double runningDistance))
                    {
                        selectedActivity = new Running(DateTime.Now, durationMinutes, runningDistance);
                    }
                    break;
                case 2:
                    Console.WriteLine("\nEnter average speed in mph:");
                    if (double.TryParse(Console.ReadLine(), out double cyclingSpeed))
                    {
                        selectedActivity = new Cycling(DateTime.Now, durationMinutes, cyclingSpeed);
                    }
                    break;
                case 3:
                    Console.WriteLine("\nEnter number of laps:");
                    if (int.TryParse(Console.ReadLine(), out int swimmingLaps))
                    {
                        selectedActivity = new Swimming(DateTime.Now, durationMinutes, swimmingLaps);
                    }
                    break;
            }

            if (selectedActivity != null)
            {
                Console.WriteLine("\n-------------------------------------------");
                Console.WriteLine(selectedActivity.GetSummary());
                Console.WriteLine("-------------------------------------------\n");
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please make sure to enter the correct type of data required for each activity.\n");
            }
        }
    }
}
