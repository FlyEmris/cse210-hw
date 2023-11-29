using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        Video video1 = new Video("Super Silly Wackadoodle", "Lord Voldamort", 300);
        Video video2 = new Video("Ammon and Friends...", "Dude", 240);
        Video video3 = new Video("There and back again and again", "Son of Sam", 180);

        video1.AddComment("Billy Bob", "I can't remember a time I laughed so hard!");
        video1.AddComment("Joe Smoe", "Haha I can't believe he did that!");
        video1.AddComment("Smeldred", "That is not going to feel good in the morning!");

        video2.AddComment("Cultivate", "I am not sure if I totally agree with Ammon's decision");
        video2.AddComment("Tri Thri Pie", "When he did the backflip my heart stopped!");
        video2.AddComment("Culturs Last Stand", "Hopefully he works it out with ken");

        video3.AddComment("yohan sebastian", "This doesn't seem lore accurate");
        video3.AddComment("Billy Boy", "yea I am not sure about the need to add more to the amazing story");
        video3.AddComment("Elf advisor", "This better not be a common trend amongst priceless stories!");

        List<Video> videos = new List<Video> {video1, video2, video3};

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberofComments()}");

            Console.WriteLine("Comments ");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($" {comment.Commenter}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}