using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your grade percent? ");
        string percent = Console.ReadLine();

        int grade = int.Parse(percent);

        string letter;
        
        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "D";
        }

        // Stretch Challenge 1
        string sign = "";

        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }

        else if (lastDigit < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        // Stretch Challenge 2
        if (grade >= 93)
        {
            sign = "";
        }

        // Stretch Challenge 3
        
        if (letter == "F")
        {
            sign = "";
        }

        Console.Write($"Your letter grade is: {letter}{sign} ");

        if (grade >= 70)
        {
            Console.Write("Congratulations! You passed the class!");
        }
        else
        {
            Console.Write("Stay focused and you'll get it next time!");
        }
    }
}