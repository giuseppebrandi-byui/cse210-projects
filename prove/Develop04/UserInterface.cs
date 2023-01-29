using System;
using System.Diagnostics;

public class UserInterface
{
    private string _activityName;
    private int _activityDuration;
    Breathing breathing = new Breathing();
    public UserInterface()
    {
    }

    // Displays the menu
    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");
        // Create a list for the menu
        List<string> activitiesMenu = new List<string>()
        { "Breathing", "Reflection", "Listing", "Quit" };

        // Loop through all values, and use i as the loop index
        for (int i = 0; i < activitiesMenu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {activitiesMenu[i]}");
        }
    }

    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    // A function that is called when the user interacts with the menu.
    public void ChooseMenuOption(
        string breathingName,
        string breathingStartMessage,
        string reflectionName,
        string reflectionStartMessage,
        string reflectionPrompt,
        string reflectionQuestion,
        string listingName,
        string listingStartMessage,
        string listingPrompt
    )
    {
        string chosenOption = "";
        while (chosenOption != "4")
        {

            // Call the DisplayMenu function
            DisplayMenu();
            Console.Write("Select choice from the menu: ");
            chosenOption = Console.ReadLine();

            /* A switch statement that is checking the value of the variable
            `chosenOption` and then executing the code in the case that matches
            the value of `chosenOption`. */
            switch (chosenOption)
            {
                // Breathing Option
                case "1":
                    _activityName = breathingName;
                    DisplayBreathingActivity(breathingStartMessage);
                    break;
                // Reflection Option
                case "2":
                    _activityName = reflectionName;
                    DisplayReflectionActivity(reflectionStartMessage, reflectionPrompt, reflectionQuestion);
                    break;
                // Listing Option
                case "3":
                    _activityName = listingName;
                    DisplayListingActivity(listingStartMessage, listingPrompt);
                    break;
                // Quit Option
                case "4":
                    Console.WriteLine("Thank you for using our program.");
                    break;
                // Print message for invalid option
                default:
                    Console.WriteLine("Invalid entry: please enter the correct menu option.");
                    break;
            }
        }
    }

    // It starts the activity and handles the user input.
    // Get the activity duration from the user input
    public void DisplayStartingMessage(string startMessage)
    {
        Console.WriteLine($"\n{startMessage}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _activityDuration = int.Parse(Console.ReadLine());
    }

    public void DisplayBreathingActivity(string breathingStartMessage)
    {
        DisplayStartingMessage(breathingStartMessage);
        Console.Clear();
        Console.WriteLine($"{Activity.preparationMessage}");
        DisplaySpinner(Activity.spinnerDuration);

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_activityDuration);

        while (currentTime < futureTime)
        {
            Console.Write($"\n\n{Breathing.breatheInMessage}");
            DisplayCountDown(Breathing.breatheInDuration);
            Console.Write($"\n{Breathing.breatheOutMessage}");
            DisplayCountDown(Breathing.breatheOutDuration);
            currentTime = DateTime.Now;
        }
        DisplayEndingMessage();
    }

    public void DisplayReflectionActivity(string reflectionStartMessage, string prompt, string question)
    {
        DisplayStartingMessage(reflectionStartMessage);
        Console.Clear();
        Console.WriteLine($"{Activity.preparationMessage}");
        DisplaySpinner(Activity.spinnerDuration);
        Console.WriteLine("\nConsider the following prompt:"
        + $"\n\n--- {prompt} ---"
        + "\n\nWhen you have something in mind, press enter to continue.");

        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        DisplayCountDown(Reflection.reflectionDuration);
        Console.Clear();
        Console.Write(question + " ");
        DisplaySpinner(Activity.spinnerDuration);
        DisplayEndingMessage();
    }

    public void DisplayListingActivity(string listingStartMessage, string prompt)
    {
        DisplayStartingMessage(listingStartMessage);
        Console.Clear();
        Console.WriteLine($"{Activity.preparationMessage}");
        DisplaySpinner(Activity.spinnerDuration);
        Console.WriteLine("\nList as many responses you can to the following prompt:"
        + $"\n\n--- {prompt} ---");
        Console.Write("You may begin in: ");
        DisplayCountDown(Reflection.reflectionDuration);
        // TO DO: user enters list
        DisplayEndingMessage();
    }

    public void DisplaySpinner(int numSecondsToRun)
    {
        int spinnerCounter = 0;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            spinnerCounter++;
            switch (spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            // go back to previous character to update it
            Console.Write("\b");
            // slow down the spinner animation
            Thread.Sleep(200);
        }
        // remove the last spinner character
        Console.Write(" ");
    }

    public void DisplayCountDown(int countDownDuration)
    {
        Console.Write(" ");
        for (int i = countDownDuration; i > 0; i--)
        {
            Console.Write("\b" + i);
            Thread.Sleep(1000);
        }
        Console.Write("\b ");
    }

    public void DisplayEndingMessage()
    {
        const int spinnerDuration = 4;
        Console.WriteLine($"\n\n{Activity.wellDoneMessage}");
        DisplaySpinner(spinnerDuration);
        Console.WriteLine($"\nYou have completed another {_activityDuration} seconds of the {_activityName} Activity.");
        DisplaySpinner(spinnerDuration);
        Console.Clear();
    }
}