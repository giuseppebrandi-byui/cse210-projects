using System;

public class ChecklistGoal : Goal
{

    // Attributes of the class
    protected int _numberOfTimes;
    protected int _actualNumberOfTimes;
    protected int _bonusPoints;
    // Contructor
    public ChecklistGoal(string type, string name, string description, int points, int numberOfTimes, int bonusPoints) : base(type, name, description, points)
    {
        _numberOfTimes = numberOfTimes;
        _bonusPoints = bonusPoints;
        _actualNumberOfTimes = 0;
    }

    public override int GetNumberOfTimes()
    {
        return _numberOfTimes;
    }

    public override int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public void RecordAchievement()
    {
        // To Do
    }

}