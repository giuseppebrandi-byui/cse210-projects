using System;

public class Controller
{
    // Class attributes
    private List<Order> _ordersList;
    private UserInterface _userInterface;

    // Unparameterized constructor
    public Controller()
    {
        _ordersList = new List<Order>();
        _userInterface = new UserInterface();
    }


    /// <summary>
    /// It takes a list of products, a customer, and a shipping cost and adds them
    /// to the order.
    /// </summary>
    /// <param name="productsList">A list of products that the customer wants to
    /// buy.</param>
    /// <param name="Customer">The customer who is placing the order.</param>
    /// <param name="shippingCost">The shipping cost of the order.</param>
    public void TakeOrder(List<Product> productsList, Customer customer, float shippingCost)
    {
        Order order = new Order(productsList, customer, shippingCost);
        _ordersList.Add(order);
    }

    /// <summary>
    /// A function that is called when the program starts.
    /// </summary>
    public void Run()
    {
        // Create a list of lists of product names for three separate orders
        List<List<string>> productNamesList = new List<List<string>> {
            new List<string>{ "Red T-shirt", "Pink Floyd T-shirt"},
            new List<string>{ "Red T-shirt", "Green T-shirt", "Guns N' Roses T-shirt"},
            new List<string>{ "Blue T-shirt", "Navy Baseball Cap", "Mitchell & Ness Chicago Bulls Snapback Cap"}
        };
        // Create a list of lists of product SKU codes for three separate orders
        List<List<string>> productIdsList = new List<List<string>> {
            new List<string>{"10001001", "10001002"},
            new List<string>{"10001001", "10001003", "10001004"},
            new List<string>{"10001005", "10001006", "10001007" }
        };
        // Create a list of lists of product prices for three separate orders
        List<List<float>> productPricesList = new List<List<float>> {
            new List<float>{10f, 10f},
            new List<float>{10f, 10f, 10f},
            new List<float>{10f, 20f, 25f}
        };
        // Create a list of lists of for the product prices in three separate orders
        List<List<int>> productQuantitiesList = new List<List<int>> {
            new List<int>{1, 1},
            new List<int>{1, 1, 1},
            new List<int>{1, 1, 1},
        };

        // Create a list of lists for the products 
        List<List<Product>> productsCollectionList = new List<List<Product>>();

        /* Iterating through the list of lists of product names. */
        for (int i = 0; i < productNamesList.Count(); i++)
        {
            // Add the product name to the list
            productsCollectionList.Add(new List<Product>());
        }

        string packagingLabel;
        List<string> packagingLabelsList = new List<string>();

        /* Iterating through the list of lists of product names. */
        for (int i = 0; i < productNamesList.Count(); i++)
        {
            packagingLabel = "";

            /* Iterating through the list of lists of product names. */
            for (int j = 0; j < productNamesList[i].Count(); j++)
            {
                // Create a list of products
                productsCollectionList[i].Add(new Product(productNamesList[i][j], productIdsList[i][j], productPricesList[i][j], productQuantitiesList[i][j]));
                packagingLabel += $"\nItem: {productNamesList[i][j]} | SKU: {productIdsList[i][j]}\n";
            }

            packagingLabelsList.Add(packagingLabel);
        }

        // Create four separate lists for the streets, cities, states, and countries
        List<string> streetsList = new List<string> { "New York Street", "LA Street", "Rue Montorgueil" };
        List<string> citiesList = new List<string> { "New York", "Los Angeles", "Paris" };
        List<string> statesList = new List<string> { "NY", "CA", "France" };
        List<string> countriesList = new List<string> { "USA", "USA", "France" };

        /* Creating a list of addresses. */
        List<Address> addressesList = new List<Address>();

        /* Creating a list of customer names. */
        List<string> customerNamesList = new List<string> { "Giuseppe Brandi", "John Doe", "Laura Colt" };

        /* Iterating through the list of streets. */
        for (int i = 0; i < streetsList.Count(); i++)
        {

            /* Creating a new address and adding it to the list of addresses. */
            addressesList.Add(new Address(streetsList[i], citiesList[i], statesList[i], countriesList[i]));
        }

        /* Creating a list of customers. */
        List<Customer> customersList = new List<Customer>();
        /* Creating a list of shipping labels. */
        List<string> shippingLabelsList = new List<string>();

        string shippingLabel;

        /* Iterating through the list of customer names. */
        for (int i = 0; i < customerNamesList.Count(); i++)
        {
            /* Creating a new customer and adding it to the list of customers. */
            customersList.Add(new Customer(customerNamesList[i], addressesList[i]));
            shippingLabel = $"\nName: {customerNamesList[i]}\nAddress: {streetsList[i]}, {citiesList[i]}, {statesList[i]}, {countriesList[i]}";
            shippingLabelsList.Add(shippingLabel);
        }

        /* Creating a list of shipping costs. */
        List<float> shippingCostsList = new List<float>();
        /* Creating a list of bills. */
        List<float> billingList = new List<float>();
        float shippingCost;
        float billing;

        /* Iterating through the list of lists of products. */
        for (int i = 0; i < productsCollectionList.Count(); i++)
        {
            /* Checking if the country is USA and if it is, it sets the shipping
            cost to $5, otherwise it sets it to $35. */
            shippingCost = customersList[i].GetAddress().GetCountry() == "USA" ? 5f : 35f;
            TakeOrder(productsCollectionList[i], customersList[i], shippingCost);
            billing = _ordersList[i].ComputeBilling();
            billingList.Add(billing);
        }

        /* Iterating through the list of orders. */
        for (int i = 0; i < _ordersList.Count(); i++)
        {
            /* Calling the `DisplayFullReport` method from the `UserInterface`*/
            _userInterface.DisplayFullReport(shippingLabelsList[i], packagingLabelsList[i], billingList[i]);
        }

    }

}