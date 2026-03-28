using System;

class Program
{
    static void Main(string[] args)

    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("MrBeast", "Last person to leave", 2000);

        Comment comment1A = new Comment("bob", "Nice Video");

        Comment comment1B = new Comment("phil", "Boo");

        Comment comment1C = new Comment("James", "Hi");

        video1.AddComment(comment1A);
        video1.AddComment(comment1B);
        video1.AddComment(comment1C);

        videos.Add(video1);


        Video video2 = new Video("John Green", "Life isn't normal", 1500);

        Comment comment2A = new Comment("Grok", "This is true");

        Comment comment2B = new Comment("John", "Sneezing is not normal");

        Comment comment2C = new Comment("Hank", "Hmmm");

        video2.AddComment(comment2A);
        video2.AddComment(comment2B);
        video2.AddComment(comment2C);

        videos.Add(video2);

            
        Video video3 = new Video("Speeed", "Nothing is normal", 1000);

        Comment comment3A = new Comment("John Paul Jones", "ok ok");

        Comment comment3B = new Comment("Niceman", "Very Nice");

        Comment comment3C = new Comment("Honk", "kmm");

        video3.AddComment(comment3A);
        video3.AddComment(comment3B);
        video3.AddComment(comment3C);

        videos.Add(video3);


        foreach (Video video in videos)
        {
            video.DisplayVideo();

            Console.WriteLine();

            Console.WriteLine("Comments");

            Console.WriteLine();

            video.DisplayAllComments();

            Console.WriteLine("========================================");
            Console.WriteLine();
        }


    }
}