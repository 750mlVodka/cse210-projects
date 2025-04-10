using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Jake Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Timex Watch", "TW38", 35.00, 1));
        order1.AddProduct(new Product("iPhone 16", "IP16", 999.00, 1));

        // Order 2
        Address address2 = new Address("106 Reforma", "Ciudad de Mexico", "CDMX", "Mexico");
        Customer customer2 = new Customer("Yamsir Hernandez", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop ", "LPZen9", 1500.00, 1));
        order2.AddProduct(new Product("Shirt Men", "SC01", 25.00, 2));
        order2.AddProduct(new Product("Backpack", "BP11", 45.00, 1));

        // Display
        DisplayOrder(order1);
        Console.WriteLine();
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalCost():F2}");
    }
}
