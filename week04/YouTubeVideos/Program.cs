using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("Learn to program in 15 minutes!", "MrCode", 900);
        video1.AddComment("TechieTom", "Wow, this was super efficient. I actually learned something!");
        video1.AddComment("CodeQueen", "Can you do one for Python next?");
        video1.AddComment("DevStarter", "Loved the pace and clarity. Subscribed!");
        _videos.Add(video1);

        Video video2 = new Video("10 programming secrets you don't know", "MrCode", 720);
        video2.AddComment("BinaryBoss", "#7 blew my mind. Never thought of that!");
        video2.AddComment("ScriptWizard", "This should be mandatory for all devs.");
        video2.AddComment("Hackerman", "I knew 3 of them, but the rest were gold.");
        _videos.Add(video2);

        Video video3 = new Video("Skywars extreme! (minecraft gameplay)", "Gokugamer999", 1200);
        video3.AddComment("BlockMaster", "That clutch at the end was insane!");
        video3.AddComment("CreeperFan", "You should try hardcore mode next time.");
        video3.AddComment("PixelPro", "Best Skywars gameplay I have seen this week!");
        _videos.Add(video3);

        Video video4 = new Video("Reacting to new technology upgrades :o", "Hi I am Willy", 600);
        video4.AddComment("FutureGeek", "That AI robot is wild. We're living in sci-fi!");
        video4.AddComment("GadgetGirl", "I want that smart mirror. Where can I buy it?");
        video4.AddComment("UpgradeHunter", "Tech is evolving so fast, it is hard to keep up!");
        _videos.Add(video4);

        foreach (Video video in _videos)
        {
            Console.WriteLine();
            video.Display();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}