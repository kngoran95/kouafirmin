using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();



        List<Video> videos = new List<Video>();


        // Video 1

        Video video1 = new Video("Introduction to C#", "Firmin", 600);

        video1.AddComment(new Comment("John", "Very good tutorial !"));
        video1.AddComment(new Comment("Marie", "Thank you for the explanations."));
        video1.AddComment(new Comment("Paul", "I learned a lot."));
        

        videos.Add(video1);

        


        // Video 2

        Video video2 = new Video("Python basics", "Koua", 800);

        video2.AddComment(new Comment("Lucas", "Excellent content."));
        video2.AddComment(new Comment("Emma", "Very useful for my training sessions."));
        video2.AddComment(new Comment("Davis", "Thanks for sharing."));

        videos.Add(video2);


        // Video 3

        Video video3 = new Video("CSS basics", "Ngoran", 750);

        video3.AddComment(new Comment("Marc", "Easy to follow."));
        video3.AddComment(new Comment("July", "Great demonstration."));
        video3.AddComment(new Comment("Nina", "Very informative."));

        videos.Add(video3);


        // Video 4

        Video video4 = new Video("Collection in C#", "Yocan", 950);

        video4.AddComment(new Comment("Laura", "I understand lists now."));
        video4.AddComment(new Comment("Hugo", "Very good presentation."));
        video4.AddComment(new Comment("Antony", "The examples are excellent."));

        videos.Add(video4);


        // Display the program

        foreach (Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine($"Title : {video.GetTitle()}");
            Console.WriteLine($"Author : {video.GetAuthor()}");
            Console.WriteLine($"Time : {video.GetLength()} second");
            Console.WriteLine($"Number of comments : {video.GetNumberOfComments()}");
            Console.WriteLine();

            
            Console.WriteLine("Comments : ");
            

            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommmentName()} : {comment.GetCommemntText()}");
                
            }
        }
        



        
    }
}