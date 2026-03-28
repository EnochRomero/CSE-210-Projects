
public class Customer
{
    private string _name;
    private Address _address;

    public Customer (string name, Address addres)
    {
        _name = name;
        _address = addres;
    }

    public bool livesInUSA()
    {
        return _address.IsUSA();
    }

    public string ReturnName()
    {
        return _name;
    }

    public void DisplayCustomerAddress()
    {
        _address.DisplayAddress();
    }


}