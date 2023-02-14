using System;

public class Product
{
    // Class attributes
    private string _name;
    private string _id;
    private float _price;
    private int _quantity;

    // Parameterized constructor
    public Product(string name, string id, float price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    // The getter returns the name of the product
    public string GetName()
    {
        return _name;
    }

    // The setter sets the name of the product
    public void SetName(string name)
    {
        _name = name;
    }

    // The getter returns the product ID
    public string GetId()
    {
        return _id;
    }

    // The setter sets the product ID
    public void Setid(string id)
    {
        _id = id;
    }

    // The getter returns the price of the product
    public float GetPrice()
    {
        return _price;
    }

    // The setter sets the price of the product
    public void SetPrice(float price)
    {
        _price = price;
    }

    // The getter returns the quantity of the product
    public int GetQuantity()
    {
        return _quantity;
    }

    // The setter sets the quantity of the product
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    // The function returns the total price
    public float ComputeTotalPrice()
    {
        return _price * _quantity;
    }
}