using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference reference = new Reference();
        reference.LoadReference();
        Scripture scripture = new Scripture();
        scripture.LoadScriptures();
        Word word = new Word();

        Console.Write("\nScripture Memorizer\n");

        while (true) // Loop indefinitely until the user decides to quit
        {
            // Prepare a scripture for memorization automatically
            string script = scripture.RandomScripture();
            string ref1 = reference.GetReference(scripture);
            word.GetRenderedText(scripture);

            // Conduct memorization session
            while (word._hidden.Count < word._result.Length)
            {
                word.Show(ref1);
                word.GetReadKey();
            }
            word.Show(ref1);

            // Ask the user if they want to continue or quit
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\nINSTRUCTIONS:\nPress enter to continue playing.\nType quit to exit the app.");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();
            if (choice == "quit") // Exit loop if user chooses to quit
            {
                break;
            }
            Console.Clear(); // Clear the console for a new session
        }

        Console.WriteLine("\n End of session\n");
    }
}
