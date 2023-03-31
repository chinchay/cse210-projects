using System;

public class Cycling : Activity {

    private float _metersPerMinute = 0.0F;

    public Cycling(string date, float minutes, float metersPerMinute) : base(date, minutes){
        SetMetersPerMinute(metersPerMinute);
    }
    public void SetMetersPerMinute(float metersPerMinute){
        _metersPerMinute = metersPerMinute;
    }

    public override float GetMeters(){
        return _metersPerMinute * GetMinutes();
    }

    public override float GetMetersPerMinute()
    {
        return _metersPerMinute;
    }

    public override string GetActivityType()
    {
        return "Cycling ";
    }



}