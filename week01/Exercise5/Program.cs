using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);

        DisplayResult(name, squared);
    }



    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }


    static string PromptUserName()
    {
        Console.Write($"Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }


    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;       
    }


    static int SquareNumber(int number)
    {
        int sum = number * number;
        return sum;
    }



    static void DisplayResult(string name, int SquaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {SquaredNumber} ");

    }

}
