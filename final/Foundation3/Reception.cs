using System;

public class Reception : Event
{
    // Class attributes
    private string _email;

    // Constructor
    public Reception(string title, string description, string date, string time,
        Address address, string type, string email) :
        base(title, description, date, time, address, type)
    {
        _email = email;
    }

    // The getter returns the email of the event
    public string GetEmail()
    {
        return _email;
    }

    // It sets the email of the event
    public void SetEmail(string email)
    {
        _email = email;
    }

    // It generates the full details for the event
    public string GenerateFullDetails()
    {
        string oneEvent = $"Event: {_title}\nDescription: {_description}\nDate: {_date}"
            + $"\nTime: {_time}\nAddress: {_address.JoinAllFields()}"
            + $"\nEvent Type: {_type}\nEmail: {_email}\n\n";
        return oneEvent;
    }

}