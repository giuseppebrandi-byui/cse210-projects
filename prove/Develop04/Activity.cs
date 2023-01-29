using System;

public class Activity
{

    // Class attributes
    protected string _startMessage;
    public const string wellDoneMessage = "Well Done!!";
    protected string _name;
    protected int _chosenDuration;
    public const string preparationMessage = "Get Ready...";
    protected bool _completed;
    public const int spinnerDuration = 4;

    // Constructor
    public Activity()
    {
        _chosenDuration = 0;
        _completed = false;
    }

    // The getter returns a string.
    public string GetStartMessage()
    {
        return _startMessage;
    }

    // It sets the start message.
    // <param name="startMessage">The message that will be displayed when the 
    // game starts.
    public void SetStartMessage(string startMessage)
    {
        _startMessage = startMessage;
    }

    // The getter returns a string.
    public string GetName()
    {
        return _name;
    }

    // It sets the name of the activity.
    // <param name="name">The name of the activity that will be displayed when
    // the game starts.
    public void SetName(string name)
    {
        _name = name;
    }

    // The getter returns a string.
    public int GetChosenDuration()
    {
        return _chosenDuration;
    }

    // It sets the duration of the activity.
    // <param name="duration">The duration of the activity.
    public void SetChosenDuration(int chosenDuration)
    {
        _chosenDuration = chosenDuration;
    }

    // The getter returns a string.
    public bool IsCompleted()
    {
        return _completed;
    }

    // It sets the completion of the activity.
    // <param name="complete">The completion of the activity.
    public void SetIsCompleted(bool completed)
    {
        _completed = completed;
    }

}