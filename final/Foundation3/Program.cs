using System;

class Program
{
    static void Main(string[] args)
    {

        Dictionary<string, string> info = new Dictionary<string, string>();
        
        info.Add( "title", "Carbon Conference 2023" );
        info.Add( "date", "June 1st" );
        info.Add( "description", "Come and learn about carbon" );
        info.Add( "time", "9:00am" );
        info.Add( "city", "Madrid" );
        info.Add( "country", "Spain" );
        info.Add( "speaker", "Prof. Jon Doe" );
        info.Add( "capacity", "100 people" );
        Event e1 = new Lecture(info);


        info["title"]    = "Picnic";
        info["date"]     = "May 1st";
        info["description"] = "Join us!";
        info["time"]     = "12:00pm";
        info["city"]     = "Rexburg, ID";
        info["country"]  = "US";
        info.Add("weatherForecast", "Sunny conditions");
        Event e2 = new OutdoorGathering(info);
        
        
        info["title"]    = "Wedding";
        info["date"]     = "December 22th";
        info["description"] = "We invite you to our wedding";
        info["time"]     = "5:50pm";
        info["city"]     = "Provo";
        info["country"]  = "US";
        info["rsvpEmail"]  = "ourwedding@wedding.com";
        Event e3 = new Reception(info);

        List<Event> listEvent = new List<Event>();
        listEvent.Add(e1);
        listEvent.Add(e2);
        listEvent.Add(e3);

        foreach(Event e in listEvent) {
            Console.WriteLine("\nShort Message");
            Console.WriteLine(e.GenerateShortMsg());
            
            Console.WriteLine("\nStandard Message");
            Console.WriteLine(e.GenerateStandardMsg());
            
            Console.WriteLine("\nFull Message");
            Console.WriteLine(e.GenerateFullMsg());

            Console.WriteLine("\n--------------");
        }

    }
}