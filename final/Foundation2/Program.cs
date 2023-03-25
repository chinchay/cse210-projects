using System;

class Program
{
    static void Main(string[] args)
    {
        //**********************************************************************
        // First order
        //**********************************************************************

        string name        = "Michael";
        string street      = "N 100 W 100";
        string city        = "Provo";
        string state       = "UT";
        string country     = "USA";

        Address address    = new Address(street, city, state, country);
        Customer customer  = new Customer(name, address);
        Order order1       = new Order(customer);

        string productName = "phone";
        string id          = "001";
        int unitPrice      = 100;
        int numberOfUnits  = 1;
        Product product1a  = new Product(productName, id, unitPrice, numberOfUnits);

        productName        = "Physics book";
        id                 = "002";
        unitPrice          = 199;
        numberOfUnits      = 1;        
        Product product1b  = new Product(productName, id, unitPrice, numberOfUnits);
        
        order1.AppendProduct(product1a);
        order1.AppendProduct(product1b);

        //**********************************************************************
        // Another order for another customer
        //**********************************************************************

        name               = "Gustavo";
        street             = "Av. Proceres 100";
        city               = "Chancay";
        state              = "Lima";
        country            = "Peru";

        Address address2   = new Address(street, city, state, country);
        Customer customer2 = new Customer(name, address2);
        Order order2       = new Order(customer2);

        productName        = "Liahona";
        id                 = "003";
        unitPrice          = 2;
        numberOfUnits      = 10;
        Product product2a  = new Product(productName, id, unitPrice, numberOfUnits);

        productName        = "Book of Mormon";
        id                 = "004";
        unitPrice          = 10;
        numberOfUnits      = 10;        
        Product product2b  = new Product(productName, id, unitPrice, numberOfUnits);
        
        order2.AppendProduct(product2a);
        order2.AppendProduct(product2b);   

        //**********************************************************************
        // Display
        //**********************************************************************
        Console.WriteLine("\n");
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine(order1.GenerateShippingLabel());
        order1.DisplayTotalCost();

        Console.WriteLine("\n");
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine(order2.GenerateShippingLabel());
        order2.DisplayTotalCost();


    }
}