using System;
class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("123 Main St", "Phoenix", "AZ", "USA");
        Customer c1 = new Customer("Javier Morales", a1);

        Order order1 = new Order(c1);
        order1.AddProduct(new Product("Laptop", "L100", 850.00, 1));
        order1.AddProduct(new Product("Mouse", "M200", 25.00, 2));

        Address a2 = new Address("45 Avenida Central", "San Jose", "SJ", "Costa Rica");
        Customer c2 = new Customer("Emily Johnson", a2);

        Order order2 = new Order(c2);
        order2.AddProduct(new Product("Headphones", "H300", 60.00, 1));
        order2.AddProduct(new Product("Keyboard", "K400", 45.00, 1));
        order2.AddProduct(new Product("USB Cable", "U500", 10.00, 3));

        Console.WriteLine("====================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine("====================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}