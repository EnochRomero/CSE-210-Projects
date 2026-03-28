using System;

public class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("bread", 1001, 2.1, 1);
        Product product2 = new Product("Milk", 1002, 2, 2);
        Product product3 = new Product("Eggs", 1003, .2, 12);

        Address address1 = new Address("123 Fake Stree", "Dallas", "TX", "USA" );
        Address address2 = new Address("303 Fun Street", "Bejin", "BL", "China" );

        Customer customer1 = new Customer("phil", address1);
        Customer customer2 = new Customer("Pual", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        Console.WriteLine($"${order1.ReturnTotalPrice()}");

        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        Console.WriteLine($"${order2.ReturnTotalPrice()}");


    }
}