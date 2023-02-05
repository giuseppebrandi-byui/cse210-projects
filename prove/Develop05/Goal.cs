using System;

public class Goal
{
    // Class attributes
    protected string _name;
    protected string _description;
    protected int _points;
    protected string _achievement;
    protected int _awardedPoints;
    protected bool _completed;
    protected string _fileName;
    protected string _type;

    // Constructor
    public Goal(string type, string name, string description, int points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _achievement = "";
        _awardedPoints = 0;
        _completed = false;
        _fileName = "";
    }

    public string GetGoalType()
    {
        return _type;
    }

    // The getter returns the goal name.
    public string GetName()
    {
        return _name;
    }

    // It sets the name of the goal.
    public void SetName(string name)
    {
        _name = name;
    }

    // The getter returns the goal description.
    public string GetDescription()
    {
        return _description;
    }

    // It sets the name of the description.
    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    // The getter returns the achievement.
    public string GetAchievement()
    {
        return _achievement;
    }

    // It sets the achievent.
    public void SetAchievement(string achievement)
    {
        _achievement = achievement;
    }

    public virtual int GetBonusPoints()
    {
        return 0;
    }

    public virtual int GetNumberOfTimes()
    {
        return 0;
    }
}