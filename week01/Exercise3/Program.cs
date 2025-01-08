using System;

class Program
{
    static void Main(string[] args)
    {
    
    string keepPlaying = "y";

    Random randomGenerator = new Random();
    
    while (keepPlaying == "y")
    {
        int number = randomGenerator.Next(1, 101);
        int counter = 0;
        int guess = 0;

        Console.Write("What is the magic number? ");

        while (guess != number)
        {
            guess = int.Parse(Console.ReadLine());
            Console.WriteLine();
            counter ++;
        
            if (guess > number)
        {
            Console.Write("Lower\nWhat is your guess? ");
        }
        
            else if (guess < number)
        {
            Console.Write("Higher\nWhat is your guess? ");
        }

        else
        {
            Console.Write("You guessed it!\n");
        }
    
        }
    // Stretch Challenge

    Console.Write($"You took {counter} guesses\n");

    Console.Write("Would you like to play again (y/n)? ");

    keepPlaying = Console.ReadLine();
    }

    Console.WriteLine("Thank you for playing. Goodbye. ");
    }
}