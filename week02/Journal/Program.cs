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

            }

            else if (entry == "2")
            {

            }

            else if (entry == "3")
            {

            }

            else if (entry == "4")
            {

            }

            else if (entry == "5")
            {
                break;
            }

            else
            {
                Console.WriteLine("Please enter a choice 1-5 ");
            }

        }
    }

}