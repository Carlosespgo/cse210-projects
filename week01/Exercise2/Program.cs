using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what was your grade percentage? ");
        string number1 = Console.ReadLine();
        float percentage = float.Parse(number1);
        string letter = "";
        string sign = "";

        if (percentage >= 90)
        {
            letter = "A";
        }

        else if (percentage >= 80)
        {
            letter = "B";
        }

        else if (percentage >= 70)
        {
            letter = "C";
        }

        else if (percentage >= 60)
        {
            letter = "D";
        }

        else if (percentage < 60)
        {
            letter = "F";
        }

        float decimals = percentage % 10;

        if (decimals >= 7)
        {
            sign = "+";
        }

        else if (decimals < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        if (letter + sign == "A+" || letter + sign == "F+" || letter + sign == "F-")
        {
            Console.WriteLine($"Your grade is: {letter}");
        }

        else
        {
            Console.WriteLine($"Your grade is: {letter + sign}");
        }

        if (percentage > 70)
        {
            Console.WriteLine("Congrats! You passed the course. Thanks for your effort!");
        }

        else
        {
            Console.WriteLine("I'm so sorry, You lost the course. I encourage you to improve the next term!");
        }
    }
}