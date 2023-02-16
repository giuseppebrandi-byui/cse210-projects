using System;

public class Outdoor : Event
{
    // Class attributes
    private string _weather;

    // Constructor
    public Outdoor(string title, string description, string date, string time,
        Address address, string type, string weather) :
        base(title, description, date, time, address, type)
    {
        _weather = weather;
    }

    // The getter returns the weather statement of the event
    public string GetWeather()
    {
        return _weather;
    }

    // It sets the weather statement of the event
    public void SetWeather(string weather)
    {
        _weather = weather;
    }

    // Generate the full details of the event
    public string GenerateFullDetails()
    {
        string oneEvent = $"Event: {_title}\nDescription: {_description}\nDate: {_date}"
            + $"\nTime: {_time}\nAddress: {_address.JoinAllFields()}"
            + $"\nEvent Type: {_type}\nWeather: {_weather}\n\n";
        return oneEvent;
    }
}