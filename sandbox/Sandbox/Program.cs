using System;

class Program
{
    static void Main(string[] args)
    {
        Device myDevice = new Device("Smart Light - Living Room");

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Turn on/off the device");
            Console.WriteLine("2. Exit the program");
            Console.Write("Select an option: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    myDevice.Toggle();
                    break;
                case "2":
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
