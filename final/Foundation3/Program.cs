using System;

class Program
{
    static void Main()
     {
        // Creating instances of each event type
        var lectureEvent = new Lecture("Stark Industries", "Exploring the latest technologies", DateTime.Now.AddDays(15), new TimeSpan(4, 30, 0), "Stc 215", "Tony Stark", 50);

        var receptionEvent = new Reception("Cybersecurity Night Banquet", "Meet and greet with the professionals!", DateTime.Now.AddDays(30), new TimeSpan(7, 0, 0), "Stc 315", true);

        var outdoorEvent = new Outdoor("Summer BBQ", "Enjoy food, games, and fun in the sun", DateTime.Now.AddDays(215), new TimeSpan(12, 0, 0), "Porter Park", "Partly Cloudy");

        // Generating and displaying marketing messages
        Console.WriteLine("Lecture Event Marketing Message:\n" + lectureEvent.Message() + "\n");

        Console.WriteLine("Reception Event Marketing Message:\n" + receptionEvent.Message() + "\n");

        Console.WriteLine("Outdoor Gathering Event Marketing Message:\n" + outdoorEvent.Message());
    }
}