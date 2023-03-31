using System;

public class Reception : Event {
    private string _rsvpEmail;

    public Reception(Dictionary<string, string> info) : base(info) {
        SetEventType("Reception");
        _rsvpEmail = info["rsvpEmail"];
    }


    public override string GenerateInfo()
    {
        string msg = "";
        msg += "RSVP Email : " + _rsvpEmail + "\n";
        return msg;
    }    
}