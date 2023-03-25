using System;

public class Customer{
    private string _name;
    private Address _address;

    public Customer(string name, Address address){
        SetName(name);
        SetAddress(address);
    }
    
    public string GetName(){
        return _name;
    }
    
    public Address GetAddress(){
        return _address;
    }
    
    public void SetName(string name){
        _name = name;
    }
    
    public void SetAddress(Address address){
        _address = address;
    }

    public bool isInUSA(){
        return _address.IsInUSA();
    }

    public string GenerateShippingLabel(){
        return _address.GenerateShippingLabel();
    }

}