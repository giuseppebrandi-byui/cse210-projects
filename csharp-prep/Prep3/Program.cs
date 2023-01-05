using System;

class Program
{
    static void Main(string[] args)
    {
        
        string playAgain = "yes";

        // Keep playing the game until the user keeps saying "yes"
        while (playAgain == "yes")
        { 
            int guess = 0;
            int numberGuesses = 0;

            // Generate a random number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            // Keep looping until the user guess the magic number
            while (guess != magicNumber)
            { 
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                // The input is assumed to be an integer
                guess = int.Parse(userGuess);

                // Count the number of attempts to guess the magic number
                numberGuesses++;

                // Check if the guessed number is equal to the magic number
                if (guess == magicNumber)
                {
                    Console.WriteLine(
                        $"You guessed it! It took you {numberGuesses} "
                        + "attempts to guess the number."
                    );
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                { 
                    Console.WriteLine("Lower");
                }

            }

            Console.Write("\nWould you like to play again? ");
            playAgain = Console.ReadLine();   
        
        }

        Console.Write("\nThank you for playing with us! See you next time.");
    }
}