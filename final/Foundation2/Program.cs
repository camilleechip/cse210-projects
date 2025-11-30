using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("552 Drive", "ID", "USA");
        Customer customer1 = new Customer("Quinn Huggins", address1);

        Address address2 = new Address("659 Circle", "UT", "USA");
        Customer customer2 = new Customer("Camille Huggins", address2);

        Address address3 = new Address("7-75 Midori", "Osaka", "Japan");
        Customer customer3 = new Customer("Aoi Tsubaki", address3);

        Product product1 = new Product("Laptop", 564875, 1, 1400);
        Product product2 = new Product("Nintendo Switch", 552164, 1, 450);
        Product product3 = new Product("FireTV", 441245, 1, 300);
        Product product4 = new Product("Playstation", 554649, 1, 250);
        Product product5 = new Product("Cable Management", 412495, 1, 35);
        
        Order order1 = new Order(customer1);
        order1.AddProduct(product2);
        order1.AddProduct(product5);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product1);

        Order order3 = new Order(customer3);
        order3.AddProduct(product1);
        order3.AddProduct(product3);
        order3.AddProduct(product5);

        Console.WriteLine("First Order:");
        Console.WriteLine($"Shipping Label: {order1.GetShippingLabel()} \nPacking Label: {order1.GetPackingLabel()} \nTotal Cost: {order1.GetTotalCost():C}");
        Console.WriteLine();

        Console.WriteLine("Second Order:");
        Console.WriteLine($"Shipping Label: {order2.GetShippingLabel()} \nPacking Label: {order2.GetPackingLabel()} \nTotal Cost: {order2.GetTotalCost():C}");
        Console.WriteLine();

        Console.WriteLine("Third Order:");
        Console.WriteLine($"Shipping Label: {order3.GetShippingLabel()} \nPacking Label: {order3.GetPackingLabel()} \nTotal Cost: {order3.GetTotalCost():C}");
        Console.WriteLine();
    }
}