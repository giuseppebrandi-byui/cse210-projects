using System;

class Program
{
    // Main program function
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        int square = SquareNumber(favNumber);
        DisplayResult(name, square);
    }

    // Display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Asks for the user name and returns its value
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Asks for the user favorite number and returns its value
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userEntry = Console.ReadLine();
        int favNumber = int.Parse(userEntry);
        return favNumber;
    }

    // Compute the square of the user favorite number
    static int SquareNumber(int num)
    {
        int square = num * num;
        return square;
    }

    // Display a message which contains the user name and the square of the 
    //favorite number
    static void DisplayResult(string name, int square)
    { 
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}