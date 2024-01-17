// While Loops
string response = "yes";

while (response == "yes")
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
}




// Do-While Loops
string response;

do
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
} while (response == "yes");