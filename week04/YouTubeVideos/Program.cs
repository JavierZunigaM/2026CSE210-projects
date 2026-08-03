using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("How to cook Pasta", "Chef Mario", 420);
        Video v2 = new Video("Learn C# in 10 Minutes", "CodeMaster", 600);
        Video v3 = new Video("Top 10 Travel Destinations", "WanderWorld", 540);

        v1.AddComment(new Comment("Ana", "Great recipe!"));
        v1.AddComment(new Comment("Luis", "I tried and love it!"));
        v1.AddComment(new Comment("Maria", "Easy to follow!"));

        v2.AddComment(new Comment("Carlos", "Very helpful Tutorial!"));
        v2.AddComment(new Comment("Jorge", "Clear and concise Explanation!"));
        v2.AddComment(new Comment("Sofia", "Thanks for sharing!"));

        v3.AddComment(new Comment("Pedro", "I want to visit all these places!"));
        v3.AddComment(new Comment("Lucia", "Amazing video!"));
        v3.AddComment(new Comment("Elena", "Beautiful destinations!"));

        List<Video> videos = new List<Video> { v1, v2, v3 };

        foreach (Video video in videos)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetAuthor()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}