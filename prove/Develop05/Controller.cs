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

        while (chosenOption != "6")
        {
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
            }
        }
    }

    public void ListGoals()
    {
        List<object> currentGoalDetailsList;
        int goalIndex = 0;

        foreach (Goal goal in _goalsList.GetGoalsList())
        {
            currentGoalDetailsList = new List<object>();
            currentGoalDetailsList.Add(goal.GetGoalType());
            currentGoalDetailsList.Add(goal.GetName());
            currentGoalDetailsList.Add(goal.GetDescription());
            currentGoalDetailsList.Add(goal.GetPoints());
            if (_userInterface.GetGoalChosenGoalType() == "3")
            {
                currentGoalDetailsList.Add((goal.GetBonusPoints()));
                currentGoalDetailsList.Add((goal.GetNumberOfTimes()));
            }
            _userInterface.DisplayGoal(currentGoalDetailsList, ++goalIndex, goal.GetNumberOfTimes());
        }
    }
}
