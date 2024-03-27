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
        videos[0].AddComment(new Comment("Alice", "This was exactly what I needed. Thanks!"));
        videos[0].AddComment(new Comment("Bob", "Clear and concise. Well done."));
        videos[0].AddComment(new Comment("Charlie", "Can you do a part 2?"));
        videos[0].AddComment(new Comment("Danielle", "Bookmarking this for future reference."));
        videos[0].AddComment(new Comment("Ethan", "The examples really helped clarify things."));
        videos[0].AddComment(new Comment("Fiona", "I appreciate your teaching style."));
        videos[0].AddComment(new Comment("George", "Brilliant explanation!"));
        videos[0].AddComment(new Comment("Hannah", "Wish I had found this video earlier."));
        videos[0].AddComment(new Comment("Ivan", "Your tutorials are the best."));
        videos[0].AddComment(new Comment("Jasmine", "Thanks for sharing your knowledge."));
        videos[0].AddComment(new Comment("Kyle", "That cleared up a lot of my questions."));
        videos[0].AddComment(new Comment("Liam", "Looking forward to more videos from you."));
        videos[0].AddComment(new Comment("Mia", "You make learning C# so much easier."));
        videos[0].AddComment(new Comment("Noah", "Finally, a tutorial that I can understand."));
        videos[0].AddComment(new Comment("Olivia", "Loved the practical examples."));
        videos[0].AddComment(new Comment("Pete", "Your explanations are so clear. Thank you!"));
        videos[0].AddComment(new Comment("Quinn", "I learned a lot from this video."));
        videos[0].AddComment(new Comment("Rachel", "This is gold for beginners like me."));
        videos[0].AddComment(new Comment("Steve", "Keep up the great work!"));
        videos[0].AddComment(new Comment("Tina", "You just gained a new subscriber."));
        videos[0].AddComment(new Comment("Umar", "Best C# tutorial I've come across."));
        videos[1].AddComment(new Comment("Audrey", "This cleared up a lot for me."));
        videos[1].AddComment(new Comment("James", "This is exactly what I was looking for, thanks!"));
        videos[1].AddComment(new Comment("Mary", "Brilliant explanation, cleared up a lot for me!"));
        videos[1].AddComment(new Comment("John", "Can you make more videos like this?"));
        videos[1].AddComment(new Comment("Patricia", "I never understood this concept until now. Thank you!"));
        videos[1].AddComment(new Comment("Robert", "Your teaching style is great, easy to follow."));
        videos[1].AddComment(new Comment("Jennifer", "Please cover more advanced topics in future videos."));
        videos[2].AddComment(new Comment("Ben", "Can't wait for the next video!"));
        videos[2].AddComment(new Comment("Olivia", "This makes so much sense now."));
        videos[2].AddComment(new Comment("Michael", "This video is a goldmine for beginners."));
        videos[2].AddComment(new Comment("Linda", "I appreciate the effort you put into this. Great job!"));
        videos[2].AddComment(new Comment("William", "The examples you used really helped me understand."));
        videos[2].AddComment(new Comment("Elizabeth", "Saved for future reference, this is so helpful!"));
        videos[2].AddComment(new Comment("David", "I've watched this three times already, it's that good."));
        videos[2].AddComment(new Comment("Barbara", "I'm sharing this with all my friends who are learning C#."));
        videos[2].AddComment(new Comment("Richard", "A thorough and engaging tutorial, well done."));
        videos[2].AddComment(new Comment("Susan", "I learned more in this video than in my last semester."));
        videos[2].AddComment(new Comment("Joseph", "Looking forward to applying these concepts in my next project."));
        videos[2].AddComment(new Comment("Jessica", "Finally, a tutorial that goes at just the right pace."));
        videos[2].AddComment(new Comment("Thomas", "Your explanations are so clear, thank you!"));
        videos[2].AddComment(new Comment("Sarah", "This has been incredibly enlightening."));
        videos[2].AddComment(new Comment("Charles", "Excellent video, it really demystifies the subject."));
        videos[2].AddComment(new Comment("Karen", "Thank you for making these videos accessible to everyone."));

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
