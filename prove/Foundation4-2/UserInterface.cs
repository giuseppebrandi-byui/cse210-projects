using System;

public class UserInterface
{
    // Unparameterized constructor
    public UserInterface()
    {

    }

    /// <summary>
    /// It displays the order details.
    /// </summary>
    /// <param name="billing">The total amount of the order.</param>
    public void DisplayOrderDetails(float billing)
    {
        Console.WriteLine($"Total (shipping included): ${billing}\n\n==============================================");
    }


    /// <summary>
    /// It displays the shipping label.
    /// </summary>
    /// <param name="shippingLabel">The shipping label to display.</param>
    public void DisplayShippingLabel(string shippingLabel)
    {
        Console.WriteLine(shippingLabel);
    }

    /// <summary>
    /// It displays the packaging label.
    /// </summary>
    /// <param name="packagingLabel">The packaging label to display.</param>
    public void DisplayPackagingLabel(string packagingLabel)
    {
        Console.WriteLine(packagingLabel);
    }

    /// <summary>
    /// It displays a full report of the shipping label, packaging label, and
    /// billing.
    /// </summary>
    /// <param name="shippingLabel">The shipping label of the package</param>
    /// <param name="packagingLabel">The label of the packaging that includes the product name and SKU
    /// used.</param>
    /// <param name="billing">The total amount of money the customer owes.</param>
    public void DisplayFullReport(string shippingLabel, string packagingLabel, float billing)
    {
        DisplayShippingLabel(shippingLabel);
        DisplayPackagingLabel(packagingLabel);
        DisplayOrderDetails(billing);
    }
}
