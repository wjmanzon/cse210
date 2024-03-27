using System;
using System.IO;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===========================================");
            Console.WriteLine("Select the type of event to display details:");
            Console.WriteLine("1. Lecture");
            Console.WriteLine("2. Reception");
            Console.WriteLine("3. Outdoor Gathering");
            Console.WriteLine("Type 'quit' to exit.");
            Console.WriteLine("===========================================");
            Console.Write("Enter your choice (1-3) or 'quit': ");
            
            string choice = Console.ReadLine()?.Trim();
            
            if (string.Equals(choice, "quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nExiting the program. Goodbye!");
                break; // Exit the loop, and thus the program
            }

            switch (choice)
            {
                case "1":
                    ReadAndPrintEvents<LectureClass>("Lectures.txt");
                    break;
                case "2":
                    ReadAndPrintEvents<ReceptionClass>("Receptions.txt");
                    break;
                case "3":
                    ReadAndPrintEvents<OutdoorGatheringClass>("OutdoorGatherings.txt");
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please enter a number between 1 and 3, or 'quit' to exit.");
                    break;
            }
        }
    }

    static void ReadAndPrintEvents<T>(string filePath) where T : Event
    {
        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            Event e = ParseEvent<T>(line);
            if (e != null)
            {
                PrintEventDetails(e);
            }
        }
    }

    static Event ParseEvent<T>(string eventData) where T : Event
    {
        var parts = eventData.Split(',');
        DateTime date = DateTime.Parse(parts[2]);
        TimeSpan time = TimeSpan.Parse(parts[3]);
        var address = new Address(parts[4], parts[5], parts[6], parts[7]);
        
        if (typeof(T) == typeof(LectureClass))
        {
            int capacity = int.Parse(parts[9]);
            return new LectureClass(parts[0], parts[1], date, time, address, parts[8], capacity);
        }
        else if (typeof(T) == typeof(ReceptionClass))
        {
            return new ReceptionClass(parts[0], parts[1], date, time, address, parts[8]);
        }
        else if (typeof(T) == typeof(OutdoorGatheringClass))
        {
            return new OutdoorGatheringClass(parts[0], parts[1], date, time, address, parts[8]);
        }
        return null; // If the type doesn't match any known event type
    }

    static void PrintEventDetails(Event e)
    {
        Console.WriteLine("\n---------------------------");
        Console.WriteLine(e.GetStandardDetails());
        Console.WriteLine("---------------------------");
        Console.WriteLine(e.GetFullDetails());
        Console.WriteLine("---------------------------");
        Console.WriteLine(e.GetShortDescription());
        Console.WriteLine("---------------------------\n");
    }
}
