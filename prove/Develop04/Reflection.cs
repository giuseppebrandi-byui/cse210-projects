using System;

public class Reflection : Activity
{

    private string _prompt;
    private string _question;
    public const int reflectionDuration = 5;
    protected List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    protected List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection() : base()
    {
        _name = "Reflection";
        _startMessage = $"Welcome to the {_name} activity"
        + "\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetQuestion()
    {
        return _question;
    }

    // It generates a random prompt from a list.
    public void GenerateRandomPrompt()
    {
        Random randomPrompt = new Random();
        int chosenPromptIndex = randomPrompt.Next(4);
        _prompt = _prompts[chosenPromptIndex];
    }

    // It generates a random question from the a list.
    public void GenerateRandomQuestion()
    {
        Random randomQuestion = new Random();
        int chosenQuestionIndex = randomQuestion.Next(9);
        _question = _questions[chosenQuestionIndex];
    }


}