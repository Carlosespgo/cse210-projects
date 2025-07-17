using System;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to: Remember the scripture!!");
        Console.WriteLine("This program will help you to memorize whatever of this scriptures: ");
        Console.WriteLine("1- Juan 3:16");
        Console.WriteLine("2- 2 Nefi 32:8-9");
        Console.WriteLine("3- Amos 3:7");
        Console.WriteLine("4- Moroni 7:45");
        Console.WriteLine("5- Moises 1:39");
        Console.Write("What would you like to memorize? : ");
        string userAnswer = Console.ReadLine();

        Console.WriteLine("Choose difficulty level: ");
        Console.WriteLine("1");
        Console.WriteLine("3");
        Console.WriteLine("5");
        Console.WriteLine("Level: ");
        string Level = Console.ReadLine();
        int difLevel;
        if (!int.TryParse(Level, out difLevel))
        {
            Console.WriteLine("Please select a valid number to the dificulty.");
            return;
        }

        Reference reference;
        Scripture scripture;

        if (userAnswer == "1")
        {
            reference = new Reference("Jhon", 3, 16);
            scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        }

        else if (userAnswer == "2")
        {
            reference = new Reference("2 Nephi", 32, 8, 9);
            scripture = new Scripture(reference, "And now, my beloved brethren, I perceive that ye ponder still in your hearts; and it grieveth me that I must speak concerning this thing. For if ye would hearken unto the Spirit which teacheth a man to pray, ye would know that ye must pray; for the evil spirit teacheth not a man to pray, but teacheth him that he must not pray.\nBut behold, I say unto you that ye must pray always, and not faint; that ye must not perform any thing unto the Lord save in the first place ye shall pray unto the Father in the name of Christ, that he will consecrate thy performance unto thee, that thy performance may be for the welfare of thy soul.");
        }

        else if (userAnswer == "3")
        {
            reference = new Reference("Amos", 3, 7);
            scripture = new Scripture(reference, "Surely the Lord God will do nothing, but he revealeth his secret unto his servants the prophets.");
        }

        else if (userAnswer == "4")
        {
            reference = new Reference("Moroni", 7, 45);
            scripture = new Scripture(reference, "And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil, and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things, believeth all things, hopeth all things, endureth all things.");
        }

        else if (userAnswer == "5")
        {
            reference = new Reference("Moses", 1, 39);
            scripture = new Scripture(reference, "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.");
        }

        else
        {
            Console.WriteLine("//Please choose one number");
            return;
        }

        while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                Console.WriteLine();
                Console.WriteLine("Push Enter to continue or type 'quit' to exit: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                scripture.HideRandomWord(difLevel);
            }
        
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

    }
}