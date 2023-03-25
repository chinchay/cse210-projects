using System;

public class Address{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country){
        SetStreet(street);
        SetCity(city);
        SetState(state);
        SetCountry(country);
    }
    
    public string GetStreet(){
        return _street;
    }
    
    public string GetCity(){
        return _city;
    }
    
    public string GetState(){
        return _state;
    }
    
    public string GetCountry(){
        return _country;
    }
    
    public void SetStreet(string street){
        _street = street;
    }
    
    public void SetCity(string city){
        _city = city;
    }
    
    public void SetState(string state){
        _state = state;
    }
    
    public void SetCountry(string country) {
        _country = country;
    }

    public bool IsInUSA(){
        return _country == "USA";
    }
    
    public string GenerateShippingLabel(){
        string addressText = $"Street : {_street}\n";
        addressText +=       $"City   : {_city}\n";
        addressText +=       $"State  : {_state}\n";
        addressText +=       $"Country: {_country}\n";
        return addressText;
    }
}