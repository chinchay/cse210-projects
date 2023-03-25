using System;

public class Order{
    private List<Product> _listProduct = new List<Product>();
    private Customer _customer;

    public Order(Customer customer){
        SetCustomer(customer);
    }

    public List<Product> GetListProduct(){
        return _listProduct;
    }

    public Customer GetCustomer(){
        return _customer;
    }

    public void AppendProduct(Product product){
        _listProduct.Add(product);
    }

    public void SetCustomer(Customer customer){
        _customer = customer;
    }

    public int ComputeTotalCost(){
        int cost = 0;
        
        foreach (Product product in _listProduct){
            cost += product.GetUnitPrice() * product.GetNumberOfUnits();
        }
        
        if (_customer.isInUSA()){
            cost += 5;
        } else {
            cost += 35;
        }
        
        return cost;
    }

    public void DisplayTotalCost(){
        Console.WriteLine("Total Cost");
        Console.WriteLine("----------");
        Console.WriteLine($"US${ComputeTotalCost().ToString()}");
    }

    public string GeneratePackingLabel(){
        
        string label = "This box contains:\n";
        label += "------------------\n";
        
        foreach (Product product in _listProduct){
            label += $"Product Name     : {product.GetProductName()}\n";
            label += $"Product ID       : {product.GetID()}\n";
            label += $"Unit price       : {product.GetUnitPrice()}\n";
            label += $"Number of units  : {product.GetNumberOfUnits()}\n";
            label += "\n";
        }
        return label;
    }

    public string GenerateShippingLabel(){
        string label = "Shipping details:\n";
        label += "-----------------\n";
        label += _customer.GenerateShippingLabel();
        label += "\n";
        return label;
    }





}