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
            Console.WriteLine(p.DisplayProduct());
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine(_customer.DisplayCustomer());
    }
}