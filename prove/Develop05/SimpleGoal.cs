using System;

public class SimpleGoal : Goal
{
    // Contructor
    public SimpleGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
    }

    // public override void RecordEvent()
    // {
    //     Console.WriteLine($"Congratulations! You have earned {0}", _points);
    //     _completed = true;
    // }

}
