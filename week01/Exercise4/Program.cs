using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int total = 0;
        int average = 0;
        int newNumber;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            string number1 = Console.ReadLine();
            newNumber = int.Parse(number1);
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
                total += newNumber;
                average = total / numbers.Count;
            }
        } while (newNumber != 0);
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");

        int largeNumber = numbers.Max();
        List<int> lessNumbers = numbers.Where(num => num > 0).ToList();
        int smallestPositive = lessNumbers.Min();
        numbers.Sort();
        Console.WriteLine($"The largest number is: {largeNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }


    }
}