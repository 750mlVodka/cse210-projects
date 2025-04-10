using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();


        Video video1 = new Video("I spent 100 hours at the Pyramids!", "MrBeast", 1200);
        video1.AddComment(new Comment("Jake", "We need an extended cut of this, must be hours worth of cool content"));
        video1.AddComment(new Comment("Bob", "This is a perfect example of money giving you access"));
        video1.AddComment(new Comment("Brenda", "Can we get 1 hour long videos of historical adventures pls❤"));
        videos.Add(video1);

        Video video2 = new Video("Cycling through Mexico alone", "Greg McCahon", 4200);
        video2.AddComment(new Comment("Stonesoop", "This is an absolute masterpiece of cinema"));
        video2.AddComment(new Comment("Melvin", "One of the best videos you have ever made."));
        video2.AddComment(new Comment("Vain", "Greg the emotional maturity you show throughout the video is incredible"));
        videos.Add(video2);

        Video video3 = new Video("A Minecraft Movie | Final Trailer", "Warner Bros", 150);
        video3.AddComment(new Comment("BlockFacts", "I really hope they actually put C418's music in the movie"));
        video3.AddComment(new Comment("Retep", "I can’t tell if people are excited or disappointed anymore"));
        video3.AddComment(new Comment("AnonymousIndian", "This new shader with RTX in Minecraft is so realistic"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }    
    }
}