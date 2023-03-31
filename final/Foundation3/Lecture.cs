using System;

public class Lecture : Event {
    private string _speaker;
    private string _capacity;

    public Lecture(Dictionary<string, string> info) : base(info) {
        SetEventType("Lecture");
        _speaker  = info["speaker"];
        _capacity = info["capacity"];
    }

    public override string GenerateInfo()
    {
        string msg = "";
        msg += "Speaker    : " + _speaker + "\n";
        msg += "Capacity   : " + _capacity + "\n";
        return msg;
    }
}