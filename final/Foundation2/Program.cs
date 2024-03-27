using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var customers = CustomerReader.ReadCustomersFromFile("customers.txt");
        var orders = OrderReader.ReadOrdersFromFile("orders.txt", customers);

        while (true)
        {
            Console.WriteLine("\nAvailable Customers:");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }

            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Enter a customer name (or type 'quit' to exit):");
            string customerName = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------");

            if (customerName.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                break; // Exit the loop and program
            }

            var selectedOrders = orders.Where(o => o.Customer.Name.Equals(customerName, StringComparison.OrdinalIgnoreCase)).ToList();
            if (selectedOrders.Any())
            {
                foreach (var order in selectedOrders)
                {
                    Console.WriteLine($"\nPacking List for {customerName}:");
                    Console.WriteLine("--------------------------------------------------");
                    foreach (var product in order.Products)
                    {
                        Console.WriteLine($"{product.Name} (ID: {product.ProductId}) - Quantity: {product.Quantity}");
                    }
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine(order.GetShippingLabel());
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine($"Original Price (before shipping): {order.OriginalPrice:C2}");
                    Console.WriteLine($"Shipping Cost: {order.ShippingCost:C2}");
                    Console.WriteLine($"Total Price: {order.CalculateTotalPrice():C2}");
                    Console.WriteLine("--------------------------------------------------\n");
                }
            }
            else
            {
                Console.WriteLine("No orders found for the specified customer.");
                Console.WriteLine("--------------------------------------------------\n");
            }
        }
    }
}
