using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        float square = SquareNumber(userNumber);
        DisplayResult(userName, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Write your favorite number (just integers): ");
        string number1 = Console.ReadLine();
        int favNumber = int.Parse(number1);
        return favNumber;
    }

    static float SquareNumber(int integer)
    {
        float numberSquare = integer * integer;
        return numberSquare;
    }

    static void DisplayResult(string name, float square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    
}