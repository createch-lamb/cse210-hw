using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("4343 Clue St", "Chitown", "IL", "USA");
        Customer customer1 = new Customer("Joseph Farlin", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Sung T.V.", "TV-007", 1299.99, 1);
        Product product2 = new Product("Remote Controlled Saucer", "RC-567", 30.00, 2);
        Product product3 = new Product("The Fetcher", "FET-321", 60.00, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine("----Order 1----");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine("\n");


        //International Customer

        Address address2 = new Address("123 Marlon Ave", "Toronto", "Ontario", "Canada" );
        Customer customer2 = new Customer("Stepen Lorde", address2);
        Order order2 = new Order(customer2);

        Product product4 = new Product("Mobile Phone", "Mobe-459", 200.00, 1);
        Product product5 = new Product("Foot Massager", "FMA-281", 150.00, 1);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("----Order 2----");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine("\n");


        //Order 3 in USA

        Address address3 = new Address("486 Cooper Dr.", "Pendleton", "OR", "USA");
        Customer customer3 = new Customer("Margie Love", address3);
        Order order3 = new Order(customer3);

        Product product6 = new Product("Foot Support", "FSP-01", 20.00, 2);
        Product product7 = new Product("Wireless Earbuds", "EAR-W01", 50.00, 1);
        Product product8 = new Product("Smart Glasses", "SGL-003", 300.00, 1);

        order3.AddProduct(product6);
        order3.AddProduct(product7);
        order3.AddProduct(product8);

        Console.WriteLine("----Order 3----");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.CalculateTotalCost():F2}");



    }
}