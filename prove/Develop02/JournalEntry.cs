class JournalEntry
{
    public string Prompt;
    public string Response;
    public DateTime Date;

    public JournalEntry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
    }
}
