public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool InUSA()
    // returns true if customer address is in the USA
    {
        return _address.InUSA();
    }

    public string DisplayCustomer()
    // Display's customer name and address
    {
        return $"{_name}\n{_address.DisplayAddress()}";
    }
}