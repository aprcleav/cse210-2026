using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Cute Sheep", "Puka Nacua", 233);
        Comment c1 = new Comment("RamGuy12", "Wow! Those are cute sheep!");
        v1.AddComment(c1);
        Comment c2 = new Comment("Kurt Warner", "Those are some great sheep!");
        v1.AddComment(c2);
        Comment c3 = new Comment("James Cook", "Eh. Cows are cuter.");
        v1.AddComment(c3);

        Video v2 = new Video("Cute Cows", "Josh Allen", 322);
        Comment c4 = new Comment("James Cook", "Yeah cows!");
        v2.AddComment(c4);
        Comment c5 = new Comment("Jane Doe", "I love cows.");
        v2.AddComment(c5);
        Comment c6 = new Comment("Aang", "Cows are awesome, buthave you seen my sky bison?");
        v2.AddComment(c6);

        Video v3 = new Video("Cute Birds", "Sam Darnold", 245);
        Comment c7 = new Comment("SeaHawk4", "GO HAWKS!!!");
        v3.AddComment(c7);
        Comment c8 = new Comment("Sokka", "Birds are great. I have one named Hawky.");
        v3.AddComment(c8);
        Comment c9 = new Comment("John Doe", "I wish I could fly...");
        v3.AddComment(c9);

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video v in videos)
        {
            v.DisplayVideo();
        }


    }
}