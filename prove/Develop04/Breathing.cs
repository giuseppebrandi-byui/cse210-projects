using System;

public class Breathing : Activity
{
    public const string breatheInMessage = "Breathe in...";
    public const string breatheOutMessage = "Now breathe out...";
    public const int breatheInDuration = 4;
    public const int breatheOutDuration = 6;

    public Breathing() : base()
    {
        _name = "Breathing";
        _startMessage = $"Welcome to the {_name} activity"
        + "\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

}