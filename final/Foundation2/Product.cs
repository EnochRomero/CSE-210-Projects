public class Product
{

    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string name, int productID, double price, int quantity)
    {
        _name = name; 
        _productID = productID;
        _price = price;
        _quantity = quantity;

    }

    public double returnTotalPrice()
    {
        double TotalPrice = _price * _quantity;

        return TotalPrice;
    }

    public string ReturnProductName()
    {
        return _name;
    }

    public int ReturnProductID()
    {
        return _productID;
    }

    
}