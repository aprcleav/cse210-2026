using System.Security.Authentication;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = state;
        _country = country;
    }

    public bool InUSA()
    // returns true if country is USA or false if it is anything else
    {
        if (_country.Trim().ToUpper() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string DisplayAddress()
    {
        return $"\t{_streetAddress}\n\t{_city}, {_stateOrProvince}\n\t{_country}\n";
    }
}