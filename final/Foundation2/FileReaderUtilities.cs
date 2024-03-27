using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class CustomerReader
{
    public static List<Customer> ReadCustomersFromFile(string filePath)
    {
        var customers = new List<Customer>();
        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var parts = line.Split(',');
            if (parts.Length >= 5)
            {
                var address = new Address(parts[1].Trim(), parts[2].Trim(), parts[3].Trim(), parts[4].Trim());
                customers.Add(new Customer(parts[0].Trim(), address));
            }
        }
        return customers;
    }
}

public static class OrderReader
{
    public static List<Order> ReadOrdersFromFile(string filePath, List<Customer> customers)
    {
        var orders = new List<Order>();
        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var parts = line.Split(',');
            if (parts.Length >= 5)
            {
                var customerName = parts[0].Trim();
                var customer = customers.FirstOrDefault(c => c.Name.Equals(customerName, StringComparison.OrdinalIgnoreCase));
                if (customer != null)
                {
                    var product = new Product(parts[1].Trim(), parts[2].Trim(), decimal.Parse(parts[3].Trim()), int.Parse(parts[4].Trim()));
                    var existingOrder = orders.FirstOrDefault(o => o.Customer.Name.Equals(customerName, StringComparison.OrdinalIgnoreCase));
                    if (existingOrder == null)
                    {
                        existingOrder = new Order(customer);
                        orders.Add(existingOrder);
                    }
                    existingOrder.Products.Add(product);
                }
            }
        }
        return orders;
    }
}
