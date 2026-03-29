using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("How to Learn C#", "CodeMaster", 600);
        v1.AddComment(new Comment("Alice", "Great tutorial!"));
        v1.AddComment(new Comment("Bob", "Very helpful."));
        v1.AddComment(new Comment("Charlie", "Loved it!"));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("OOP Explained", "TechGuru", 820);
        v2.AddComment(new Comment("David", "Now I understand OOP."));
        v2.AddComment(new Comment("Eve", "Nice explanation."));
        v2.AddComment(new Comment("Frank", "Thanks a lot!"));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("C# Classes Tutorial", "DevSimplified", 540);
        v3.AddComment(new Comment("Grace", "Super clear."));
        v3.AddComment(new Comment("Hank", "This helped a lot."));
        v3.AddComment(new Comment("Ivy", "Awesome content!"));
        videos.Add(v3);

        // Display
        Console.WriteLine("===== YOUTUBE VIDEO ANALYSIS =====\n");

        foreach (Video video in videos)
        {
            Console.WriteLine("====================================");
            Console.WriteLine($"- Title   : {video.GetTitle()}");
            Console.WriteLine($"-Author  : {video.GetAuthor()}");
            Console.WriteLine($"-Length  : {video.GetFormattedLength()}");
            Console.WriteLine($"-Comments: {video.GetCommentCount()}");
            Console.WriteLine("------------------------------------");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: \"{comment.GetText()}\"");
            }

            Console.WriteLine("====================================\n");
        }
    }
}