class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string option = Console.ReadLine();

            if (option == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();

                JournalEntry entry = new JournalEntry(prompt, response);
                journal.AddEntry(entry);
            }
            else if (option == "2")
            {
                journal.DisplayJournal();
            }
            else if (option == "3")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveJournal(filename);
                Console.WriteLine("Journal saved.");
            }
            else if (option == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadJournal(filename);
                Console.WriteLine("Journal loaded.");
            }
            else if (option == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option, please try again.");
            }
        }
    }
}
