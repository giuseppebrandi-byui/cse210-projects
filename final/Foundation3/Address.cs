public class Address
{
    // Class attributes
    private string _street;
    private string _city;
    private string _postCode;

    // Parameterized Constructor
    public Address(string street, string city, string state)
    {
        _street = street;
        _city = city;
        _postCode = state;
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
        return _postCode;
    }

    // It sets the name of the state
    public void SetState(string state)
    {
        _postCode = state;
    }


    // It joins all address details in a string
    public string JoinAllFields()
    {
        return $"{_street}, {_city}, {_postCode}";
    }
}