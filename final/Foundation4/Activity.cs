using System;

public abstract class Activity {

    private string _date;
    private float _minutes = 0.0F;
    private string _activityType;

    public Activity(string date, float minutes) {
        SetDate(date);
        SetMinutes(minutes);
    }

    public void SetDate(string date){_date = date;}
    public void SetMinutes(float minutes){_minutes = minutes;}
    public void SetActivityType(string activityType){_activityType = activityType;}
    public string GetDate(){return _date;}
    public float GetMinutes(){return _minutes;}


    public abstract string GetActivityType();
    public abstract float GetMeters();
    public abstract float GetMetersPerMinute();


    public float GetPace()
    {
        float speed = GetMetersPerMinute();
        if (speed > 0){
            return 1.0F / speed;
        }
        return 0.0F;
    }

    public void GetSummary(){
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        string text = "";
        text += _date + " ";
        text += GetActivityType() + " ";
        text += "(" + _minutes + " min)- Distance: ";
        text += GetMeters() + " meters, Speed: ";
        text += GetMetersPerMinute() + " meters per minute, Pace: ";
        text += GetPace() + " min per meter";
        Console.WriteLine(text);
    }

}