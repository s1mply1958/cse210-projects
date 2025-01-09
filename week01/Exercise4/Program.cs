using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
    // Declare a list
    //numbers = []
    List<int> numbers = new List<int>();

    // Declare a variable
    int mynumber = 1;

    Console.Write("Enter a list of numbers, type 0 when finished.\nEnter a number: ");

    // Keep inputing numbers until number = 0
    while (mynumber != 0)
        {
        //number = int(input('Enter a number '))
        Console.Write("Enter a number: ");
        mynumber = int.Parse(Console.ReadLine());

        //Console.Write("Enter a number: ");
        
        if (mynumber != 0)
        {
            numbers.Add(mynumber);
        }
        
        }
        
        /////////////////////////////////////////////////////////////
        // Sum
        // Declare a variable
        int sum = 0;

        // Loop through the 'numbers' list, for each 'number' from the input
        foreach (int number in numbers)
        {
            sum += number;
        }    

        Console.WriteLine($"The sum is: {sum}");

        /////////////////////////////////////////////////////////////
        // Average

        // Declare variables
        // counter = len(numbers)
        {
        int count = numbers.Count;
        float average = ((float)sum) / count;
    
        Console.WriteLine($"The average is: {average}");
        }
        /////////////////////////////////////////////////////////////
        // Largest
        int CurrentHighest = 0;

        foreach (int number in numbers)
        
            if (number > CurrentHighest)
        {
                CurrentHighest = number;
        }
        Console.WriteLine($"The largest number is: {CurrentHighest}");

        ///////////////////////
        // Stretch Challenge //
        ///////////////////////
        // Smallest
        int CurrentSmallest = 999999999;

        foreach (int number in numbers)

            if (number > 0 && number < CurrentSmallest)
            {
                CurrentSmallest = number;
            }
        Console.WriteLine($"The smallest positive number is: {CurrentSmallest}");

        /////////////////////////////////////////////////////////////
        // Sorted list

        Console.WriteLine("The sorted list is: ");
        
        foreach (int number in numbers)

        Console.WriteLine(number);

    }
}