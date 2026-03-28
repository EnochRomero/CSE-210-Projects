public class Order
{
    private Customer _customer;

    private List<Product> _products = new List<Product>();


    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }


    public double ReturnTotalPrice()
    {
        double totalPrice = 0;

        foreach(Product product in _products)
        {
            totalPrice += product.returnTotalPrice();
        }

        if(_customer.livesInUSA() == true)
        {
            totalPrice += 5;
        }

        else
        {
            totalPrice += 35;
        }

        return totalPrice;
        
    }

    public void DisplayPackingLabel()
    {
        foreach(Product product in _products)
        {
            Console.WriteLine($"Product Name: {product.ReturnProductName()}");
            Console.WriteLine($"Product ID: {product.ReturnProductID()}");
            Console.WriteLine($"=======================================");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"Customer Name: {_customer.ReturnName()}");
        Console.WriteLine($"Address:");
        _customer.DisplayCustomerAddress();
    }
}