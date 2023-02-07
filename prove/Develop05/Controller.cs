using System;

public class Controller
{
    private GoalsList _goalsList;
    private UserInterface _userInterface;
    private int totalPoints;

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
        List<string> linesList = new List<string>();
        List<object> currentGoalDetailsList;

        totalPoints = 0;

        while (chosenOption != "6")
        {
            _userInterface.DisplayScore(totalPoints);
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
                    ListBriefGoals();
                    RecordAchievements();
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

        Console.WriteLine("The goals are:");

        foreach (Goal goal in _goalsList.GetGoalsList())
        {
            string goalDescription = goal.MakeDescription(++goalIndex, false);
            _userInterface.DisplayGoal(goalIndex, goal.GetGoalType(), goalDescription);
        }
    }

    public void ListBriefGoals()
    {
        int goalIndex = 0;

        Console.WriteLine("The goals are:");

        foreach (Goal goal in _goalsList.GetGoalsList())
        {
            Console.WriteLine($"{++goalIndex}. {goal.GetName()}");
        }
    }

    public void RecordAchievements()
    {
        int awardedPoints;

        Console.Write("Which goal did you accomplish? ");
        int accomplishedGoalIndex = int.Parse(Console.ReadLine());
        Goal accomplishedGoal = _goalsList.GetGoalsList()[accomplishedGoalIndex - 1];
        awardedPoints = accomplishedGoal.GetPoints();
        Console.WriteLine($"Congratulations you have gained {awardedPoints} points.");
        totalPoints += awardedPoints;
        accomplishedGoal.SetCompleted(true);
    }
}
