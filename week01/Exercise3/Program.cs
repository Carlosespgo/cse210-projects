using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 20);
        int attempts = 1;
        string keep;

        do
        {
            magic = randomGenerator.Next(1, 20);
            Console.Write("What is your guess? ");
            string number1 = Console.ReadLine();
            int guess = int.Parse(number1);
            while (guess != magic)
            {
                if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magic)
                {
                    Console.WriteLine("Lower");
                }
                Console.Write("What is your guess? ");
                number1 = Console.ReadLine();
                guess = int.Parse(number1);
                attempts += 1;
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"you had {attempts} attempts.");

            Console.WriteLine("Do you wanna play again?(yes/no): ");
            keep = Console.ReadLine();
        } while (keep == "yes");
        Console.WriteLine("Thank you for playing. Goodbye.");
    }
}