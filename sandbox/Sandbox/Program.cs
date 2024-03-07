using System;

class Program
{
    static void Main(string[] args)
    {
        // Initial setup
        var light = new SmartLight("Living Room Light");
        var heater = new SmartHeater("Living Room Heater");
        var tv = new SmartTV("Living Room TV");
        var livingRoom = new Room("Living Room");
        livingRoom.AddDevice(light);
        livingRoom.AddDevice(heater);
        livingRoom.AddDevice(tv);

        while (true)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Turn on all lights");
            Console.WriteLine("2. Turn off all lights");
            Console.WriteLine("3. Turn on a specific device");
            Console.WriteLine("4. Turn off a specific device");
            Console.WriteLine("5. Turn on all devices in the room");
            Console.WriteLine("6. Turn off all devices in the room");
            Console.WriteLine("7. Report all items in the room and their status");
            Console.WriteLine("8. Report all items that are on");
            Console.WriteLine("9. Report the item that has been on the longest");
            Console.WriteLine("0. Exit");
            Console.Write("Selection: ");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    livingRoom.TurnOnAllLights();
                    break;
                case "2":
                    livingRoom.TurnOffAllLights();
                    break;
                case "3":
                    Console.Write("Enter device name to turn on: ");
                    var onDeviceName = Console.ReadLine();
                    // livingRoom.TurnOnDevice(onDeviceName);
                    break;
                case "4":
                    Console.Write("Enter device name to turn off: ");
                    var offDeviceName = Console.ReadLine();
                    // livingRoom.TurnOffDevice(offDeviceName);
                    break;
                case "5":
                    livingRoom.TurnOnAllDevices();
                    break;
                case "6":
                    livingRoom.TurnOffAllDevices();
                    break;
                case "7":
                    livingRoom.ReportAllItemsStatus();
                    break;
                case "8":
                    // livingRoom.ReportAllItemsOn();
                    break;
                case "9":
                    livingRoom.ReportItemOnLongest();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid selection, please try again.");
                    break;
            }
        }
    }
}
