using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Game of your life!!!");
        Console.WriteLine("In this game you can win points and achieve goals of your life like a truly videogame!");
        GoalManager manager = new GoalManager();
        Console.WriteLine();
        manager.Start();
        Console.WriteLine("Thanks for play!!");
    }
}