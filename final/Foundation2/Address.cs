using System;

public class Address
{
    // Class attributes
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Parameterized Constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // The getter returns the name of the street
    public string GetStreet()
    {
        return _street;
    }

    // It sets the name of the street
    public void SetStreet(string street)
    {
        _street = street;
    }

    // The getter returns the name of the city
    public string GetCity()
    {
        return _city;
    }

    // It sets the name of the city
    public void SetCity(string city)
    {
        _city = city;
    }

    // The getter returns the name of the state
    public string GetState()
    {
        return _state;
    }

    // It sets the name of the state
    public void SetState(string state)
    {
        _state = state;
    }

    // The getter returns the name of the country
    public string GetCountry()
    {
        return _country;
    }

    // It sets the name of the country
    public void SetCountry(string country)
    {
        _country = country;
    }

    // It returns true only if country is equal to USA
    public bool IsInUSA()
    {
        return _country == "USA";
    }

    // It joins all address details in a string
    public string JoinAllFields()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}