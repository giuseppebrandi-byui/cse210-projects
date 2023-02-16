using System;

public class Event
{
    // Class attributes
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _type;

    // Constructor
    public Event(string title, string description, string date, string time, Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    // The getter returns the title of the event
    public string GetTitle()
    {
        return _title;
    }

    // It sets the title of the event
    public void SetTitle(string title)
    {
        _title = title;
    }

    // The getter returns the description of the event
    public string GetDescription()
    {
        return _description;
    }

    // It sets the description of the event
    public void SetDescription(string description)
    {
        _description = description;
    }

    // The getter returns the date of the event
    public string GetDate()
    {
        return _date;
    }

    // It sets the date of the event
    public void SetDate(string date)
    {
        _date = date;
    }

    // The getter returns the time of the event
    public string GetTime()
    {
        return _time;
    }

    // It sets the time of the event
    public void SetTime(string time)
    {
        _time = time;
    }

    // The getter returns the address object of the event
    public Address GetAddress()
    {
        return _address;
    }

    // It sets the address object of the event
    public void SetAddress(Address address)
    {
        _address = address;
    }

    // The getter returns the type of the event
    public string GetTypeEvent()
    {
        return _type;
    }

    // It sets the type of the event
    public void SetType(string type)
    {
        _type = type;
    }

    // Generate Standard Details
    public string GenerateStandardDetails()
    {
        string oneEvent = $"Title: {_title}\nDescription: {_description}\nDate: "
            + $"{_date}\nTime: {_time}\nAddress: {_address.JoinAllFields()}\n";
        return oneEvent;
    }

    // Generate Short Details
    public string GenerateShortDetails()
    {
        string oneEvent = $"Type: {_type}\nTitle: {_title}\nDate: {_date}\n";
        return oneEvent;
    }


}


