using System;

public class Listing : Activity
{

    public const int listingDuration = 5;
    private string _prompt;
    protected List<string> _promptsList = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing() : base()
    {
        _name = "Listing";
        _startMessage = $"Welcome to the {_name} activity"
        + "\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    // The getter returns a string.
    public string GetPrompt()
    {
        return _prompt;
    }

    // It generates a random prompt from a list.
    public void GenerateRandomPrompt()
    {
        Random randomPrompt = new Random();
        int chosenPromptIndex = randomPrompt.Next(5);
        _prompt = _promptsList[chosenPromptIndex];
    }

}