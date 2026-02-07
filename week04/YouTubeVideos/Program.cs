using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Simple Study Tips", "Ellie's Corner", 1200);
        video1.AddComment(new Comment("Kristy", "Wonderful!"));
        video1.AddComment(new Comment("Jackson", "Terrific Video"));
        video1.AddComment(new Comment("Scott", "Very Detailed"));
        videos.Add(video1);

        Video video2 = new Video("The Cool Secrets Hidden In Roblox", "Action Jackson", 1800);
        video2.AddComment(new Comment("Jackie", "Great video. Look forward to more"));
        video2.AddComment(new Comment("Eliana", "You are so authentic"));
        video2.AddComment(new Comment("Mariah", "I enjoyed it very much"));
        video2.AddComment(new Comment("Ruth", "Fantastic"));
        videos.Add(video2);

        Video video3 = new Video("Basketball Technique For Girls", "Rye Knows Best", 1600);
        video3.AddComment(new Comment("Connor", "Rad!"));
        video3.AddComment(new Comment("Christine", "Thank You!"));
        video3.AddComment(new Comment("Bernie", "Love"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()} ");
            Console.WriteLine("Comments: ");

            foreach (Comment comment in video.GetComments())
            {
                Console. WriteLine($"  -  {comment.CommenterName}:  {comment.Text}");
            }

            Console.WriteLine();

        }
    }
}