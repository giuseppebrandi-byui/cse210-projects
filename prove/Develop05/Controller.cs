using System;

public class Controller
{
    private GoalsList _goalsList;
    private UserInterface _userInterface;
    public Controller()
    {
        _goalsList = new GoalsList();
        _userInterface = new UserInterface();
    }

    // A function that is called when the program is run.
    public void Run()
    {
        string chosenOption = "";
        string fileName;
        int points = 0;
        List<string> linesList = new List<string>();
        List<object> currentGoalDetailsList;

        while (chosenOption != "6")
        {
            _userInterface.DisplayScore(points);
            chosenOption = _userInterface.ChooseMenuOption();

            switch (chosenOption)
            {
                case "1":
                    _userInterface.ChooseGoalType();
                    currentGoalDetailsList = _userInterface.GetGoalDetailsList();
                    _goalsList.SetGoalDetailsList(currentGoalDetailsList);
                    _goalsList.CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    fileName = _userInterface.ReadFileName(true);
                    _goalsList.SetFileName(fileName);
                    _goalsList.SaveToFile();
                    break;
                case "4":
                    fileName = _userInterface.ReadFileName(false);
                    _goalsList.SetFileName(fileName);
                    _goalsList.LoadFromFile();
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
        }
    }

    public void ListGoals()
    {
        int goalIndex = 0;

        Console.WriteLine("The Goals are:");

        foreach (Goal goal in _goalsList.GetGoalsList())
        {
            string goalDescription = goal.MakeDescription(++goalIndex, false);
            _userInterface.DisplayGoal(goalIndex, goal.GetGoalType(), goalDescription);
        }
    }
}
