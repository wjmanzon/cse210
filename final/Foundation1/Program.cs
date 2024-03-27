using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of videos
        List<Video> videos = new List<Video>
        {
            new Video("How to Program in C#", "CoderA", 600),
            new Video("Understanding Abstraction", "EducatorB", 300),
            new Video("Principles of OOP", "InstructorC", 450)
        };

        // Add comments to each video
        videos[0].AddComment(new Comment("Alejandro", "Great tutorial!"));
        videos[0].AddComment(new Comment("Leah", "Very helpful, thanks!"));
        videos[1].AddComment(new Comment("Audrey", "This cleared up a lot for me."));
        videos[2].AddComment(new Comment("Ben", "Can't wait for the next video!"));
        videos[2].AddComment(new Comment("Olivia", "This makes so much sense now."));

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine(); // Add an empty line for better readability
        }
    }
}
