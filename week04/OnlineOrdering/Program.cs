using System;
using OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
                // This line of code create an addresses
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("Accra Street", "Abuja", "FCT", "Nigeria");

        // This line of codes reate customers
        Customer customer1 = new Customer("Nephi Amos", address1);
        Customer customer2 = new Customer("Daniel Udung", address2);

        // This line of codes create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.50m, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Smartphone", "P003", 499.99m, 1));
        order2.AddProduct(new Product("Headphones", "P004", 89.99m, 1));

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {      
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.TotalCost():0.00}\n");
    }
}