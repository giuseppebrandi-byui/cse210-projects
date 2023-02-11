using System;

public class Order
{
    /* A private variable that is a list of products. */
    private List<Product> _productsList;
    /* A private variable that is a customer. */
    private Customer _customer;
    /* A private variable that is a shipping cost. */
    private float _shippingCost;

    /// Parameterized constructor
    public Order(List<Product> productsList, Customer customer, float shippingCost)
    {
        _productsList = productsList;
        _customer = customer;
        _shippingCost = shippingCost;
    }

    /// <summary>
    /// It returns a list of products.
    /// </summary>
    public List<Product> GetProductsList()
    {
        return _productsList;
    }

    /// <summary>
    /// It sets the productsList to the list of products passed in.
    /// </summary>
    /// <param name="productsList">The list of products that you want to display in
    /// the list.</param>
    public void SetProductsList(List<Product> productsList)
    {
        _productsList = productsList;
    }

    /// <summary>
    /// It returns a Customer object.
    /// </summary>
    public Customer GetCustomer()
    {
        return _customer;
    }

    /// <summary>
    /// Sets the customer
    /// </summary>
    /// <param name="Customer">The customer object that you want to set.</param>
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public float GetShippingCost()
    {
        return _shippingCost;
    }

    public void SetShippingCost(float shippingCost)
    {
        _shippingCost = shippingCost;
    }

    /// <summary>
    /// It computes the billing.
    /// </summary>
    public float ComputeBilling()
    {
        float productsCost = 0;

        foreach (Product product in _productsList)
        {
            productsCost += product.ComputeTotalPrice();
        }

        return productsCost + _shippingCost;
    }


}