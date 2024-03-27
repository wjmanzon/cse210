using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = LoadVideosFromFile("videos.txt");
        LoadCommentsFromFile("comments.txt", videos);

        while (true) // Start an infinite loop
        {
            // Display video titles
            Console.WriteLine("\nAvailable Videos:");
            for (int i = 0; i < videos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {videos[i].Title}");
            }

            // Prompt user for a selection
            Console.WriteLine("\nEnter the number of the video you want to view details for, or type 'quit' to exit:");
            string input = Console.ReadLine();

            // Check if user wants to quit
            if (input.ToLower() == "quit")
            {
                break; // Exit the loop
            }

            // Attempt to parse user input into an integer and select video
            if (int.TryParse(input, out int selectedVideoIndex) && selectedVideoIndex >= 1 && selectedVideoIndex <= videos.Count)
            {
                selectedVideoIndex -= 1; // Adjust for zero-based indexing
                Video selectedVideo = videos[selectedVideoIndex];
                Console.WriteLine($"\nTitle: {selectedVideo.Title}, Author: {selectedVideo.Author}, Length: {selectedVideo.LengthInSeconds} seconds");
                Console.WriteLine($"Number of Comments: {selectedVideo.GetNumberOfComments()}");
                foreach (Comment comment in selectedVideo.GetComments())
                {
                    Console.WriteLine($"- {comment.Name}: {comment.Text}");
                }
            }
            else
            {
                Console.WriteLine("Invalid selection. Please enter a valid video number or 'quit' to exit.");
            }
        }

        Console.WriteLine("Program exited successfully.");
    }

    static List<Video> LoadVideosFromFile(string filePath)
    {
        List<Video> videos = new List<Video>();
        string[] lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length == 3)
            {
                videos.Add(new Video(parts[0], parts[1], int.Parse(parts[2])));
            }
        }
        return videos;
    }

    static void LoadCommentsFromFile(string filePath, List<Video> videos)
    {
        string[] commentLines = File.ReadAllLines(filePath);
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
    }
}
