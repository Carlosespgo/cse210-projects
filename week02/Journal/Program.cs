using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string choice;
        Journal myJournal = new Journal();

        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Save");
            Console.WriteLine("4.Load");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                PromptGenerator prompt = new PromptGenerator();
                string randomPrompt = prompt.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                string userAnswer = Console.ReadLine();

                Entry entry = new Entry();
                entry._entryText = userAnswer;
                entry._promptText = randomPrompt;
                entry._date = DateTime.Today.ToString("dd/MM/yyyy");

                myJournal.AddEntry(entry);
            }

            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.WriteLine("Write the filename to save: ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }

            else if (choice == "4")
            {
                Console.WriteLine("Write the filename to load: ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }

            Console.WriteLine();

        } while (choice != "5");
        

    }
}