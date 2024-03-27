using System;
using System.Collections.Generic;
using System.IO; // Include for file reading

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

        // Load comments from file
        string[] commentLines = File.ReadAllLines("comments.txt");
        foreach (var line in commentLines)
        {
            var parts = line.Split('|');
            if (parts.Length == 3)
            {
                int videoIndex = int.Parse(parts[0]);
                if (videoIndex >= 0 && videoIndex < videos.Count)
                {
                    videos[videoIndex].AddComment(new Comment(parts[1], parts[2]));
                }
            }
        }

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
