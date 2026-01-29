public class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double CalculateTotalCost()
    // Multiplies price by quantity to calculate total cost
    {
        return _price * _quantity;
    }

    public string DisplayProduct()
    // Displays product name and ID
    {
        return $"Product: {_name}, ID: {_id}";
    }
}