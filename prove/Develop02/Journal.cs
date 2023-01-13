using System;

public class Journal
{
    // Create an empty list.
    public List<Entry> _entries = new List<Entry>();
    public string _fileName;

    // Add the entry data from the user. 
    public void AddEntryFromUser()
    {
        Entry userEntry = new Entry();
        userEntry.GenerateDate();
        userEntry.GeneratePrompt();
        userEntry.ReadResponse();
        _entries.Add(userEntry);
    }

    // Add the entry data from a file.
    public void AddEntryFromFile(string date, string prompt, string response)
    {
        Entry entry = new Entry();
        entry._date = date;
        entry._prompt = prompt;
        entry._response = response;
        _entries.Add(entry);
    }

    // It displays the entries in the database.
    public void DisplayEntries()
    {

        // Looping through the list of entries and printing them out.
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}\n{entry._response}");
        }
    }

    // It saves the entries to a file.
    public void SaveEntriesToFile()
    {
        Console.Write("Please enter a filename to save the journal: ");
        _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            // Check if the file name ends with ".csv"
            if (_fileName.EndsWith(".csv"))
            {
                // header;
                outputFile.WriteLine("Date,Prompt,Response");
                // Looping through the list of entries and printing them out.
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
                }
            }
            else
            {
                // Looping through the list of entries and printing them out.
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}\n{entry._response}");
                }
            }
        }
    }

    // It loads the journal from previously saved file.
    public void LoadEntriesFromFile()
    {
        Console.Write("Please enter a filename to load a saved journal: ");
        _fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        string date = "";
        string prompt = "";
        _entries.Clear();

        foreach (string line in lines)
        {
            if (line.Contains("-"))
            {
                string[] date_prompt = line.Split(" -");
                date = date_prompt[0].Split(": ")[1];
                prompt = date_prompt[1].Split(": ")[1];
            }
            else
            {
                string response = line;
                AddEntryFromFile(date, prompt, response);
            }
        }
    }
}