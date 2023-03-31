using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");

        string date   = "01 Jan 2021";
        float minutes = 11;
        float meters  = 111;
        Activity a1 = new Running(date, minutes, meters);


        date   = "02 Feb 2022";
        minutes = 22;
        float meterPerMinute = 20;
        Activity a2 = new Cycling(date, minutes, meterPerMinute);


        date   = "03 March 2023";
        minutes = 13;
        float numberOfLaps = 3;
        Activity a3 = new Swimming(date, minutes, numberOfLaps);

        List<Activity> listActivity = new List<Activity>();
        listActivity.Add(a1);
        listActivity.Add(a2);
        listActivity.Add(a3);

        foreach(Activity activity in listActivity){
            activity.GetSummary();
        }

    }
}