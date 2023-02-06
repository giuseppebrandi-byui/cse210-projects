using System;

public class UserInterface
{
    private string _chosenGoalTypeChoice;
    private List<object> _currentGoalDetailsList;

    public UserInterface()
    {
        _currentGoalDetailsList = new List<object>();
    }

    public string GetGoalChosenGoalType()
    {
        return _chosenGoalTypeChoice;
    }

    public List<object> GetGoalDetailsList()
    {
        return _currentGoalDetailsList;
    }

    public void DisplayScore(int points)
    {
        Console.WriteLine($"\nYou have {points} points.");
    }

    // Displays the menu
    public void DisplayMenu()
    {
        Console.WriteLine("\nMenu Options:");
        // Create a list for the menu
        List<string> MainMenu = new List<string>()
        { "Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit" };

        // Loop through all values, and use i as the loop index
        for (int i = 0; i < MainMenu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {MainMenu[i]}");
        }
    }

    // A function that is called when the user interacts with the menu.
    public string ChooseMenuOption()
    {
        string chosenOption = "";

        // Call the DisplayMenu function
        DisplayMenu();
        Console.Write("Select a choice from the menu: ");
        chosenOption = Console.ReadLine();

        /* A switch statement that is checking the value of the variable
        `chosenOption` and then executing the code in the case that matches
        the value of `chosenOption`. */
        switch (chosenOption)
        {
            // Create New Goal 
            case "1":
                ChooseGoalType();
                break;
            // List Goals
            case "2":
                Console.WriteLine("The Goals are:");
                break;
            // Save Goals
            case "3":
                // TO DO
                break;
            // Load Goals
            case "4":
                // TO DO
                break;
            // Record Event
            case "5":
                // TO DO
                break;
            // Quit Option
            case "6":
                Console.WriteLine("Thank you for using our program.");
                break;
            // Print message for invalid option
            default:
                Console.WriteLine("Invalid entry: please enter the correct menu option.");
                break;
        }
        return chosenOption;
    }

    public void ChooseGoalType()
    {
        // Create a list for the menu
        List<string> GoalTypeMenu = new List<string>()
        { "Simple Goal", "Eternal Goal", "Checklist Goal"};

        Console.WriteLine("The types of goals are:");

        // Loop through all values, and use i as the loop index
        for (int i = 0; i < GoalTypeMenu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {GoalTypeMenu[i]}");
        }

        _currentGoalDetailsList = new List<object>();
        Console.Write("Which type of goal would you like to create? ");
        _chosenGoalTypeChoice = Console.ReadLine();
        _currentGoalDetailsList.Add(_chosenGoalTypeChoice);
        if (!ValidateGoalDetails())
        {
            Console.WriteLine("Invalid goal type choice: please enter 1-3.");
            return;
        }

        ReadGoalDetails();
    }

    public bool ValidateGoalDetails()
    {
        if (!_chosenGoalTypeChoice.Contains("1")
            && !_chosenGoalTypeChoice.Contains("2")
            && !_chosenGoalTypeChoice.Contains("3"))
        {
            Console.WriteLine("Invalid entry: please enter the correct menu option.");
            return false;
        }

        return true;
    }

    public void ReadGoalDetails()
    {
        int numberOfTimes = 0;
        int bonusPoints = 0;

        Console.Write("What is the name of the goal? ");
        string name = Console.ReadLine();
        _currentGoalDetailsList.Add(name);
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        _currentGoalDetailsList.Add(description);
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        _currentGoalDetailsList.Add(points);

        if (_chosenGoalTypeChoice == "3")
        {
            Console.Write("How many times this goal need to be accomplished for a bonus? ");
            numberOfTimes = int.Parse(Console.ReadLine());
            _currentGoalDetailsList.Add(numberOfTimes);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            bonusPoints = int.Parse(Console.ReadLine());
            _currentGoalDetailsList.Add(bonusPoints);
        }
    }

    public void DisplayGoal(int goalIndex, string goalType, string goalDescription)
    {
        string[] goalDescriptionList = goalDescription.Split("\n");
        Console.Write($"{goalDescriptionList[0]}");
        if (goalType == "Checklist")
        {
            Console.Write($" -- Currently completed: {goalDescriptionList[1]}");
        }

        Console.WriteLine();
    }

    public string ReadFileName()
    {
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();
        return fileName;
    }

}