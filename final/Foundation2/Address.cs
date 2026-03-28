

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsUSA()
    {
        bool USACheck;

        if (_country == "USA")
        {
            USACheck = true;
        }

        else {USACheck = false;}

        return USACheck;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"{_streetAddress}");
        Console.WriteLine($"{_city}, {_state}");
        Console.WriteLine($"{_country}");

    }
    
}