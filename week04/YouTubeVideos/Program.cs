using System;
using YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold videos
        List<Video> videos = new List<Video>();

        // Create videos and add comments
        Video video1 = new Video("Understanding C#", "D", 300);
        video1.AddComment(new Comment("Alfred", "Great lessons!"));
        video1.AddComment(new Comment("Baby", "Interesting ...."));
        video1.AddComment(new Comment("Aboy", "Thanks for sharing this idea!"));
        videos.Add(video1);

        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 450);
        video2.AddComment(new Comment("David", "Very informative!"));
        video2.AddComment(new Comment("Ernest", "I love this insight."));
        videos.Add(video2);

        Video video3 = new Video("C# Best Practices", "Daniel Udung", 600);
        video3.AddComment(new Comment("Friday", "This is good!"));
        video3.AddComment(new Comment("Thursday", "Helpful content."));
        video3.AddComment(new Comment("Monday", "Keep it up!"));
        videos.Add(video3);

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}