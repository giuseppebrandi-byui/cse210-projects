using System;

public class UserInterface
{
    public UserInterface()
    {
    }

    // It displays the current scripture.
    // <param name="Scripture">The current scripture that is being displayed.
    public void DisplayCurrentScripture(Scripture currentScripture)
    {
        // Clear screen
        Console.Clear();
        // Display the Scripture reference
        Console.Write(currentScripture.GetReference() + " ");

        /* Iterating through the dictionary of words and their appearances. */
        foreach (KeyValuePair<string, bool> wordAppearance in currentScripture.GetWordAppearances())
        {
            if (wordAppearance.Value)
            {
                Console.Write(wordAppearance.Key);
            }
            else
            {
                // Replace each character in a word with underscore
                Console.Write(new string('_', wordAppearance.Key.Length));
            }
            Console.Write(" ");
        }

        // Display instruction for the user
        Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
    }

    // It handles the user input.
    public string GetUserResponse()
    {
        string response = Console.ReadLine();
        return response;
    }
}