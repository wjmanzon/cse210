public class Comment
{
    public string Name { get; set;} // Commenter's name
    public string Text { get; set; } // Comment text

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}