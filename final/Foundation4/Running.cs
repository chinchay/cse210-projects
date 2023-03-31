using System;

public class Running : Activity {
    
    private float _meters = 0.0F;

    public Running(string date, float minutes, float meters) : base(date, minutes){
        SetMeters(meters);
    }

    public void SetMeters(float meters){
        _meters = meters;
    }

    public override float GetMeters(){
        return _meters;
    }

    public override float GetMetersPerMinute()
    {
        float minutes = GetMinutes();
        if (minutes > 0) {
            return GetMeters() / minutes;
        }
        return 0.0F;
        
    }


    public override string GetActivityType()
    {
        return "Running ";
    }





}