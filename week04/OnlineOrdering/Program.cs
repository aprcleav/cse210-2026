using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("12345 Gavin Rd", "El Paso", "Texas", "USA");
        Customer customer1 = new Customer("Rosey Smith", address1);
        Product p1 = new Product("Milk", 3001, 3.99, 2);
        Product p2 = new Product("Cheese", 4003, 2.99, 1);
        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        order1.CalculateTotalCost();
    }
}