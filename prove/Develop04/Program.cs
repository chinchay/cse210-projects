using System;

class Program
{
    static void Main(string[] args)
    {
        string menu = "Menu Options:\n" +
            "  1. Start breathing activity\n" +
            "  2. Start reflecting activity\n" +
            "  3. Start listing activity\n" +
            "  4. Quit\n" +
            "Select a choice from the menu: ";
        //
        
        string input = "";

        for (int i = 0; i < 10; i++) {
            Console.Write(menu);
            input = Console.ReadLine();

            if (input == "4") {
                break;
            }

            switch( input ){
                case "1":
                    BreathingActivity b = new BreathingActivity();
                    b.run();
                    Console.Clear();
                    break;
                case "2":
                    ReflectionActivity r = new ReflectionActivity();                    
                    r.run();
                    Console.Clear();
                    break;
                case "3":
                    ListingActivity l = new ListingActivity();
                    l.run();
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    break;

            }
        }
    }


}