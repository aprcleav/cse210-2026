using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;

public class Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    // Checks if customer country is USA. If true, it sets shipping to 5. If false, shipping is set to 35. Calculates total cost by adding the shipping value to the Product class's CalculateTotalCost() method
    {
        double totalCost = 0;
        int shippingCost;
        
        if (_customer.InUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        foreach (Product p in _products)
        {
            totalCost += p.CalculateTotalCost();
        }

        return totalCost + shippingCost;
    }

    public void DisplayPackingLabel()
    {
        foreach (Product p in _products)
        {
            Console.WriteLine($"\t{p.DisplayProduct()}");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"\t{_customer.DisplayCustomer()}");
    }
}