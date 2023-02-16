using System;

public class Lecture : Event
{
    // Class attributes
    private string _speaker;
    private int _capacity;

    // Constructor
    public Lecture(string title, string description, string date, string time,
        Address address, string type, string speaker, int capacity) :
        base(title, description, date, time, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // The getter returns the speaker of the event
    public string GetSpeaker()
    {
        return _speaker;
    }

    // It sets the speaker of the event
    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }

    // The getter returns the capacity of the event
    public int GetCapacity()
    {
        return _capacity;
    }

    // It sets the capacity of the event
    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    // Generate the full details of the event
    public string GenerateFullDetails()
    {
        string oneEvent = $"Event: {_title}\nDescription: {_description}\nDate: {_date}"
            + $"\nTime: {_time}\nAddress: {_address.JoinAllFields()}\nEvent Type: "
            + $"{_type}\nSpeaker: {_speaker}\nCapacity: {_capacity}\n\n";
        return oneEvent;
    }
}