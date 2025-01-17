using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator.Prompts();

        while (true)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string entry = Console.ReadLine();
            int choice = int.Parse(entry);

            if (entry == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your input: ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry (DateTime.Now.ToShortDateString(), prompt, response);
                journal.AddEntry(newEntry);

            }

            else if (entry == "2")
            {
                journal.DisplayAll();
            }

            else if (entry == "3")
            {
                Console.Write("Enter file name to load: ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);

            }

            else if (entry == "4")
            {
                Console.Write("Enter file name to save: ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);

            }

            else if (entry == "5")
            {
                break;
            }

            else
            {
                Console.WriteLine("Please enter a choice between 1-5 ");
            }

        }
    }

}