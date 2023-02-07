using System;

public class GoalsList
{
    private string _fileName;
    // Class attributes
    private Goal _currentGoal;
    private List<Goal> _goalsList;
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

    // The setters sets the goal name
    public void SetFileName(string fileName)
    {
        _fileName = fileName;
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
                _currentGoal = new SimpleGoal(
                    "Simple",
                    _currentGoalDetailsList[1].ToString(),
                    _currentGoalDetailsList[2].ToString(),
                    int.Parse(_currentGoalDetailsList[3].ToString())
                );
                break;
            case "2":
                _currentGoal = new EternalGoal(
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
                    int.Parse(_currentGoalDetailsList[4].ToString())
                );
                break;
        }
        _goalsList.Add(_currentGoal);
    }

    // It saves the list of goals in a file
    public void SaveToFile()
    {
        List<string> linesToFileList = new List<string>();

        int lineCounter = 0;

        foreach (Goal goal in _goalsList)
        {
            linesToFileList.Add(goal.MakeDescription(++lineCounter, true));
        }

        File.WriteAllLines(_fileName, linesToFileList);
    }

    // It loads a previously saved file with the list of goals
    public void LoadFromFile()
    {
        StreamReader streamReader = new StreamReader(_fileName);

        _goalsList.Clear();

        while (!streamReader.EndOfStream)
        {
            string goalDetails = streamReader.ReadLine();
            string[] goalDetailsList = goalDetails.Split(" | ");
            if (goalDetailsList.Length == 6)
            {
                _goalsList.Add(new Goal(goalDetailsList[1], goalDetailsList[2], goalDetailsList[3], int.Parse(goalDetailsList[4])));
            }
            else
            {
                _goalsList.Add(new ChecklistGoal(goalDetailsList[1], goalDetailsList[2], goalDetailsList[3],
                    int.Parse(goalDetailsList[4]), int.Parse(goalDetailsList[6].Split("/")[1])));
            }

        }
        streamReader.Close();

    }

}