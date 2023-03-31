using System;

public class Address{
    string _city;
    string _country;

    public string GetCity(){return _city;}
    public string GetCountry(){return _country;}
    public void SetCity(string city){_city = city;}
    public void SetCountry(string country){_country = country;}

    public string GetAddress(){
        string text = $"{_city}, {_country}";
        return text;
    }
}