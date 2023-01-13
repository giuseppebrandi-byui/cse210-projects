using System;

class Program
{
    public Journal _journal = new Journal();

    static void Main(string[] args)
    {
        string titleArt = @"
(\ 
\'\ 
 \'\     __________  
 / '|   ()_________)
 \ '/    \ ~~~~~~~~ \
   \       \ ~~~~~~   \
   ==).      \__________\
  (__)       ()__________)";

        Console.WriteLine(titleArt);
        Console.WriteLine("\nWelcome to the Journal Program!");
        InteractWithMenu();
    }

    // Displays the menu
    static public void DisplayMenu()
    {
        Console.WriteLine("\nPlease select one of the following choices: ");
        // Create a list for the menu
        List<string> journalMenu = new List<string>()
        { "Write", "Display", "Load", "Save", "Quit" };

        // Loop through all values, and use i as the loop index
        for (int i = 0; i < journalMenu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {journalMenu[i]}");
        }
    }

    // A function that is called when the user interacts with the menu.
    static public void InteractWithMenu()
    {
        Program program = new Program();
        string chosenOption = "";
        while (chosenOption != "5")
        {

            // Call the DisplayMenu function
            DisplayMenu();
            Console.Write("What would you like to do? ");
            chosenOption = Console.ReadLine();

            /* A switch statement that is checking the value of the variable
            `chosenOption` and then executing the code in the case that matches
            the value of `chosenOption`. */
            switch (chosenOption)
            {
                // Write Option
                case "1":
                    program._journal.AddEntryFromUser();
                    break;
                // Display Option
                case "2":
                    program._journal.DisplayEntries();
                    break;
                // Load Option
                case "3":
                    program._journal.LoadEntriesFromFile();
                    break;
                // Save Option
                case "4":
                    program._journal.SaveEntriesToFile();
                    break;
                // Quit Option
                case "5":
                    Console.WriteLine("Thank you for using our program.");
                    break;
                // Print message for invalid option
                default:
                    Console.WriteLine("Invalid entry: please enter the correct menu option.");
                    break;
            }
        }
    }
}