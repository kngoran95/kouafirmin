using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();


        // Customer 1 (USA)

        Address address1 = new Address("123 Main Street", "New York", "NY", "USA");

        Customer customer1 = new Customer("John Smith", address1);


        Order order1 = new Order(customer1);


        order1.AddProduct(new Product("Laptop", "P100", 850, 1));

        order1.AddProduct(new Product("Mouse", "P101", 25, 2));


        // Customer 2 (International)

        Address address2 = new Address("45 Paris Street", "Ivory Coast", "Japan", "Abidjan");

        Customer customer2 = new Customer("Koua", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Earpiece", "E201", 40, 3));

        // Display order 1

        Console.WriteLine("Order 1 : ");
        Console.WriteLine("Shipping label : ");
        Console.WriteLine(order1.GetShippingLabel());


        Console.WriteLine("Packaging label : ");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine($"Total cost: {order1.CalculateTotalCost()}");
        Console.WriteLine();


        // Display order 2

        Console.WriteLine("Order 2: ");
        Console.WriteLine("Shipping label: ");
        Console.WriteLine(order2.GetShippingLabel());


        Console.WriteLine("Packaging label: ");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine($"Total cost: {order2.CalculateTotalCost()}");
    }
}