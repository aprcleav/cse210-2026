using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("ORDER 1:\n");
        Address address1 = new Address("12345 Gavin Rd", "El Paso", "Texas", "USA");
        Customer customer1 = new Customer("Rosey Smith", address1);
        Product p1 = new Product("Milk", 3001, 3.99, 2);
        Product p2 = new Product("Cheese", 4003, 2.99, 1);
        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        Console.WriteLine("PACKING LABEL: ");
        order1.DisplayPackingLabel();

        Console.WriteLine("\nSHIPPING LABEL: ");
        order1.DisplayShippingLabel();

        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine("ORDER 2: \n");
        Address address2 = new Address("2417 Burrard Ave", "Vanderhoof", "BC", "Canada");
        Customer customer2 = new Customer("Jonathan Doeser", address2);
        Product p3 = new Product("iPad", 6005, 799.77, 1);
        Product p4 = new Product("iPhone", 6007, 1299.99, 1);
        Product p5 = new Product("Airpods", 6009, 299.99, 1);
        Order order2 = new Order(customer2);
        order2.AddProduct(p3);
        order2.AddProduct(p4);
        order2.AddProduct(p5);

        Console.WriteLine("PACKING LABEL: ");
        order2.DisplayPackingLabel();

        Console.WriteLine("\nSHIPPING LABEL: ");
        order2.DisplayShippingLabel();
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}