using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        int number;
        int sum = 0;
        double average = 0;
        int largestNumber = -1;
        int smallestNumber = 999999999;

        // Create a list
        List<int> numbersList = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Keep asking the user to provide a number until they enter 0
        do
        {
            Console.Write("Enter a number: ");
            string userEntry = Console.ReadLine();
            // The inputs are assumed to be integers
            number = int.Parse(userEntry);

            // Add the user entry to the list unless they enter 0
            if (number != 0)
            {
                numbersList.Add(number);
            }
        } while (number != 0);

        // Sort the list
        numbersList.Sort();

        foreach (int num in numbersList)
        { 

            // Determine the largest number in the numbersList
            if (num > largestNumber)
            {
                largestNumber = num;
            }

            // Determine the smallest positive number in the numbersList
            if (num < smallestNumber && num >= 1)
            {
                smallestNumber = num;
            }

            // Compute the sum of the numbers in the list
            sum += num;
        }

        // Compute the average
        average = (double)sum / numbersList.Count;

        Console.WriteLine($"The sum is: {sum}\n"
            + $"The average is: {average}\n"
            + $"The largest number is: {largestNumber}\n"
            + $"The smallest positive number is: {smallestNumber}\n"
            + "The sorted list is:"
        );


        // Print a sorted list of numbers in the numbersList
        foreach (int num in numbersList)
        {
            Console.WriteLine(num);
        }

    }
}