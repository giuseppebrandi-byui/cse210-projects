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

        while (chosenOption != "6")
        {
            _userInterface.DisplayScore(points);
            chosenOption = _userInterface.ChooseMenuOption();

            List<object> currentGoalDetailsList = _userInterface.GetGoalDetailsList();
            _goalsList.SetGoalDetailsList(currentGoalDetailsList);


            switch (chosenOption)
            {
                case "1":
                    _goalsList.CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    fileName = _userInterface.ReadFileName();
                    _goalsList.SetFileName(fileName);
                    _goalsList.SaveToFile();
                    break;

            }
        }
    }

    public void ListGoals()
    {
        int goalIndex = 0;

        foreach (Goal goal in _goalsList.GetGoalsList())
        {
            string goalDescription = goal.MakeDescription(++goalIndex, false);
            _userInterface.DisplayGoal(goalIndex, goal.GetGoalType(), goalDescription);
        }
    }
}
