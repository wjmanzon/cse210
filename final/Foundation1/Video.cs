using System.Collections.Generic;

public class Video
{
    public string Title { get; set; } // Video title
    public string Author { get; set; } // Video author
    public int LengthInSeconds { get; set; } // Video length in seconds
    private List<Comment> comments = new List<Comment>(); // List of comments

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
    }

    // Add a comment to the video
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Get the number of comments
    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    // Get all comments
    public List<Comment> GetComments()
    {
        return comments;
    }
}
