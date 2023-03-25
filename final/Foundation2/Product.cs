using System;

public class Product{

    private string _productName;
    private string _id;
    private int _unitPrice;
    private int _numberOfUnits;

    public Product(string productName, string id, int unitPrice, int numberOfUnits){
        SetProductName(productName);
        SetID(id);
        SetUnitPrice(unitPrice);
        SetNumberOfUnits(numberOfUnits);
    }

    public string GetProductName(){
        return _productName;
    }
    
    public string GetID(){
        return _id;
    }
    
    public int GetUnitPrice(){
        return _unitPrice;
    }
    
    public int GetNumberOfUnits(){
        return _numberOfUnits;
    }
    
    public void SetProductName(string productName){
        _productName = productName;
    }
    
    public void SetID(string id){
        _id = id;
    }
    
    public void SetUnitPrice(int unitPrice){
        _unitPrice = unitPrice;
    }
    
    public void SetNumberOfUnits(int numberOfUnits){
        _numberOfUnits = numberOfUnits;
    }

}