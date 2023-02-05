using System;

public class GoalsList
{
    // Class attributes
    private List<Goal> _goalsList;
    private Goal _currentGoal;
    private List<object> _currentGoalDetailsList;

    // Constructor
    public GoalsList()
    {
        _goalsList = new List<Goal>();
    }

    // The getter returns the goal name.
    public List<Goal> GetGoalsList()
    {
        return _goalsList;
    }
    public void SetGoalDetailsList(List<object> goalDetailsList)
    {
        _currentGoalDetailsList = goalDetailsList;
    }

    public void CreateGoal()
    {
        switch (_currentGoalDetailsList[0])
        {
            case "1":
                _currentGoal = new Goal(
                    "Simple",
                    _currentGoalDetailsList[1].ToString(),
                    _currentGoalDetailsList[2].ToString(),
                    int.Parse(_currentGoalDetailsList[3].ToString())
                );
                break;
            case "2":
                _currentGoal = new Goal(
                    "Eternal",
                    _currentGoalDetailsList[1].ToString(),
                    _currentGoalDetailsList[2].ToString(),
                    int.Parse(_currentGoalDetailsList[3].ToString())
                );
                break;
            case "3":
                _currentGoal = new ChecklistGoal(
                    "Checklist",
                    _currentGoalDetailsList[1].ToString(),
                    _currentGoalDetailsList[2].ToString(),
                    int.Parse(_currentGoalDetailsList[3].ToString()),
                    int.Parse(_currentGoalDetailsList[4].ToString()),
                    int.Parse(_currentGoalDetailsList[5].ToString())
                );
                break;
        }
        _goalsList.Add(_currentGoal);
    }
}