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

    public void SaveToFile()
    {
        List<string> linesList = new List<string>();

        int lineCounter = 0;

        foreach (Goal goal in _goalsList)
        {
            linesList.Add(goal.MakeDescription(++lineCounter, true));
        }

        File.WriteAllLines(_fileName, linesList);
    }

    public List<String> LoadFromCSV(string _fileName)
    {
        List<string> fromFile = new List<string>();
        StreamReader streamReader = new StreamReader(_fileName);

        while (!streamReader.EndOfStream)
        {
            string line = streamReader.ReadLine();
            fromFile.Add(line.ToString());
        }
        streamReader.Close();

        return fromFile;
    }
}