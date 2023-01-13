using System;

public class Entry
{
    // Class attributes
    public string _date;
    public string _prompt;
    public string _response;

    // Generate the date for the entry
    public void GenerateDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

    // Generate a prompt question from a list
    public void GeneratePrompt()
    {
        // Create a list for the menu
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "If you could change something in your life what it would be?"
        };

        // Use random to randomly select a prompt from a list
        _prompt = prompts[new Random().Next(prompts.Count)];
        // Display prompt to the user
        Console.WriteLine(_prompt);
    }

    public void ReadResponse()
    {
        Console.Write("> ");
        _response = Console.ReadLine();

    }
}