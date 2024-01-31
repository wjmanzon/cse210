class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}\nPrompt: {entry.Prompt}\nResponse: {entry.Response}\n");
        }
    }

    public void SaveJournal(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename, true))
        {
            foreach (var entry in entries)
            {
                sw.WriteLine($"Date: {entry.Date}\nPrompt: {entry.Prompt}\nResponse: {entry.Response}\n");
            }
        }
    }

    public void LoadJournal(string filename)
    {
        entries.Clear();
        using (StreamReader sr = new StreamReader(filename))
        {
            while (!sr.EndOfStream)
            {
                string dateLine = sr.ReadLine();
                string prompt = sr.ReadLine();
                string response = sr.ReadLine();
                sr.ReadLine(); // Skip the empty line

                DateTime date = DateTime.Parse(dateLine.Split(' ')[1].Trim());
                JournalEntry entry = new JournalEntry(prompt, response) { Date = date };
                entries.Add(entry);
            }
        }
    }
}
