using System.Collections.Generic;
using System.Linq;

public class Order
{
    public List<Product> Products { get; private set; } = new List<Product>();
    public Customer Customer { get; private set; }

    public Order(Customer customer)
    {
        Customer = customer;
    }

    // Calculates the original price of all products (before shipping)
    public decimal OriginalPrice => Products.Sum(p => p.TotalCost);

    // Determines the shipping cost based on the customer's location
    public decimal ShippingCost => Customer.LivesInUSA() ? 5m : 35m;

    // Calculates the total price, including shipping
    public decimal CalculateTotalPrice()
    {
        return OriginalPrice + ShippingCost;
    }

    // Generates a packing label including the customer's name
    public string GetPackingLabel(string customerName)
    {
        var label = $"Packing List for {customerName}:\n";
        foreach (var product in Products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label.TrimEnd();
    }

    // Generates a shipping label with the customer's name and address
    public string GetShippingLabel()
    {
        return $"Shipping To:\n{Customer.Name}\n{Customer.Address.GetFormattedAddress()}";
    }
}
