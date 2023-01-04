using System;

class Program
{
    static void Main(string[] args)
    {

         // Constants
        const string plusSign = "+";
        const string minusSign = "-";

        // Variables
        string letter;
        string letterSign;
        string outcomeMessage;

        // Ask the user to enter a percentage value
        Console.Write("Please enter your grade percentage (ex. 94): ");
        string gradeFromUser = Console.ReadLine();
        // Convert the string value entered by the user into an integer
        int grade = int.Parse(gradeFromUser);
        int lastDigit = grade % 10;

        // The conditional checks for the grade percentage and then assigns a
        // value to the letter variable
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
        else {
            letter = "F";
        }

        letterSign = letter;

        // The conditional checks for the last digit of the percentage value
        // entered by the user and the letter. 
        
        if (lastDigit >= 7 && new List<string>(){"B", "C", "D"}
        .Contains(letter))
        {
            letterSign += plusSign;
        }
        else if (lastDigit < 3 && new List<string>(){"A", "B", "C", "D"}
        .Contains(letter))
        { 
            letterSign += minusSign;
        }

        Console.WriteLine($"Your letter grade is: {letterSign}");


        // The conditional checks if the grade is greater or equal to 70. 
        // A message is printed depending if the condition is met or not.
        outcomeMessage = grade >= 70 ? "Congratulations you passed the course!"
         : "You will do better next time!";
        Console.WriteLine(outcomeMessage);

    }
}