using System;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("Get Ready With Me", "Nikita Dragun", 300);
        video1.AddComment(new Comment("Beautiful outfit!", "Jenny"));
        video1.AddComment(new Comment("Love your makeup choice!", "Shannon"));
        video1.AddComment(new Comment("I need that vanity set!", "Alice"));

        Video video2 = new Video("Useful Winter Skincare Tips", "James Welsh",550);
        video2.AddComment(new Comment("These are actually so helpful.", "Gabriella"));
        video2.AddComment(new Comment("My skin is always so dry in the winter!", "Bree"));
        video2.AddComment(new Comment("That is my favorite moisturizer.", "Erin"));
        video2.AddComment(new Comment("Love the tips.", "Emma"));

        Video video3 = new Video("Vinyasa Flow", "Yoga With Adriene", 960);
        video3.AddComment(new Comment("I do this every morning!", "Jess"));
        video3.AddComment(new Comment("Great yoga practice.", "Lyla"));
        video3.AddComment(new Comment("Thanks for the amazing video!", "Tina"));

        List<Video> videos = new List<Video> {video1, video2, video3};
        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.GetTitle()} | Author: {v.GetAuthor()} | Length: {v.GetLength()} | Comments: {v.GetCommentCount()}");
            Console.WriteLine();

            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($"{c.GetCommentName()}- {c.GetCommentText()}");
                Console.WriteLine();
            }
        }
    }
}