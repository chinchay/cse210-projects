using System;

public class Swimming : Activity {

    private float _numberOfLaps = 0;
    private float _distancePerLap = 50;

    public Swimming(string date, float minutes, float numberOfLaps): base(date, minutes){
        SetNumberOfLaps(numberOfLaps);
    }

    public void SetNumberOfLaps(float numberOfLaps){
        _numberOfLaps = numberOfLaps;
    }

    public override float GetMeters(){
        return _distancePerLap * _numberOfLaps;
    }

    public override float GetMetersPerMinute()
    {
        float minutes = GetMinutes();
        if (minutes > 0){
            return GetMeters() / minutes;
        }
        return 0.0F;
        
    }

    public override string GetActivityType()
    {
        return "Swimming";
    }



}