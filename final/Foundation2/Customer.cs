using System;

public class Customer
{
    // Class attributes
    private string _name;

    private Address _address;

    // Create a parameterized constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // The getter returns the name of the customer
    public string GetName()
    {
        return _name;
    }

    // The setter sets the name of the customer
    public void SetName(string name)
    {
        _name = name;
    }

    // The getter returns the address of the customer
    public Address GetAddress()
    {
        return _address;
    }

    // The setter sets the address of the customer
    public void SetAddress(Address address)
    {
        _address = address;
    }

    // Check if the customer lives is in the US
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}