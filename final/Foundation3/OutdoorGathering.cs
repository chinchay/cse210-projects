using System;

public class OutdoorGathering : Event {

    private string _weatherForecast;

    public OutdoorGathering(Dictionary<string, string> info) : base(info) {
        SetEventType("Outdoor gathering");
        _weatherForecast = info["weatherForecast"];
    }


    public override string GenerateInfo()
    {
        string msg = "";
        msg += "Weather    : " + _weatherForecast + "\n";
        return msg;
    }    

}