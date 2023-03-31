using System;

public class Event{
    string _title;
    string _date;
    string _description;
    string _time;
    Address _address = new Address();
    string _eventType;

    public Event(Dictionary<string, string> info){
        SetTitle(info["title"]);
        SetDate(info["date"]);
        SetDescription(info["description"]);
        SetTime(info["time"]);
        SetAddress(info["city"], info["country"]);
    }

    public string GetTitle(){return _title;}
    public string GetDate(){return _date;}
    public string GetDescription(){return _description;}
    public string GetTime(){return _time;}
    public string GetAddress(){return _address.GetAddress();}
    public string GetEventType(){return _eventType;}

    public void SetTitle(string title){_title = title;}
    public void SetDate(string date){_date = date;}
    public void SetDescription(string description){_description = description;}
    public void SetTime(string time){_time = time;}
    public void SetAddress(string city, string country){
        _address.SetCity(city);
        _address.SetCountry(country);
    }
    public void SetEventType(string eventType){_eventType = eventType;}


    private string GenerateFirstBaseMessage(){
        string msg = "";
        msg += "Title      : " + _title + "\n";
        msg += "Date       : " + _date  + "\n";
        return msg;
    }

    private string GenerateSecondBaseMessage(){
        string msg = "";
        msg += "Description: " + _description + "\n";
        msg += "Time       : " + _time        + "\n";
        msg += "Address    : " + _address.GetAddress() + "\n";        
        return msg;
    }

    public string GenerateShortMsg(){
        string msg = GenerateFirstBaseMessage();
        msg += "Event type : " + _eventType + "\n";
        return msg;
    }

    public string GenerateStandardMsg(){
        string msg = GenerateFirstBaseMessage();
        msg += GenerateSecondBaseMessage();
        return msg;
    }

    public string GenerateFullMsg(){
        string msg = GenerateFirstBaseMessage();
        msg += GenerateSecondBaseMessage();
        msg += "Event type : " + _eventType   + "\n";
        msg += GenerateInfo();
        return msg;
    }

    public virtual string GenerateInfo(){
        return "";
    }


}