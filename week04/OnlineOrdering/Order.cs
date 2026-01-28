using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;

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

    public void CalculateTotalCost()
    {
        // fix this method - logic issues. iteration is wrong.
        double shipping;
        foreach (Product p in _products)
        {
            if (_customer.InUSA())
            {
                shipping = p.CalculateTotalCost() + 5;
            }
            else
            {
                shipping = p.CalculateTotalCost() + 35;
            }
            Console.WriteLine(shipping);
        }
    }

    public void DisplayPackingLabel()
    {
        foreach (Product p in _products)
        {
            p.DisplayProduct();
        }
    }

    public void DisplayShippingLabel()
    {
        _customer.DisplayCustomer();
    }
}