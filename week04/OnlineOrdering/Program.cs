using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(new Customer("John Doe", new Address("123 Main St", "New York", "NY", "USA"), "123-456-7890"),
            new List<Product> { new Product("Laptop", 999.99, 1, 1546), new Product("Mouse", 19.99, 2, 15463) });
        order1.AddProduct(new Product("Keyboard", 49.99, 1, 15464));

        Order order2 = new Order(new Customer("Jane Smith", new Address("456 Elm St", "Toronto", "ON", "Canada"), "987-654-3210"),
            new List<Product> { new Product("Phone", 699.99, 1, 15465), new Product("Charger", 29.99, 1, 15466) });

        // Print packing labels and total prices for both orders
        Console.WriteLine($"First Order:");
        Console.WriteLine($"\n");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine( order1.GetShippingLabel());
        Console.WriteLine($"Total Price: $ {order1.GetTotalPrice()}");
        Console.WriteLine($"\n");
        Console.WriteLine($"\n");
        Console.WriteLine($"Second Order:");
        Console.WriteLine($"\n");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine( order2.GetShippingLabel());
        Console.WriteLine($"Total Price: $ {order2.GetTotalPrice()}");
    }
}