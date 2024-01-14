using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade? ");
        string GradeString = Console.ReadLine();
        int Grade = int.Parse(GradeString);

        // Console.WriteLine($"Your grade is {Grade}");
        /*
        if (Grade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (Grade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (Grade >= 70)
        {
            Console.WriteLine("C");
        }
        else if (Grade >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
        */

        string letter;

        if (Grade >= 90)
        {
            letter = "A";
        }
        else if (Grade >= 80)
        {
            letter = "B";
        }
        else if (Grade >= 70)
        {
            letter = "C";
        }
        else if (Grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (Grade >= 70)
        {
            Console.WriteLine("Congrats, you passed! Keep it up!");
        }
        else
        {
            Console.WriteLine("Sorry, you failed. Try harder next time!");
        }
    }
}