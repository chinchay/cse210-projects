public class ListingActivity : Activity {
    List<string> _listQuestions = new List<string>();

    public ListingActivity() : base() {
        SetActivityType("Listing Activity");

        string q1 = "Who are people that you appreciate?";
        string q2 = "What are personal strengths of yours?";
        string q3 = "Who are people that you have helped this week?";
        string q4 = "When have you felt the Holy Ghost this month?";
        string q5 = "Who are some of your personal heroes?";

        _listQuestions.Add(q1);
        _listQuestions.Add(q2);
        _listQuestions.Add(q3);
        _listQuestions.Add(q4);
        _listQuestions.Add(q5);
    }

    public override void ExplainActivity(){
        string message = "Welcome to the Listing Activity.\n\n" + 
        "This activity will help you reflect on the good things in your " +
        "by having you list as many things as you can in a certain area.\n\n";
        
        Console.WriteLine(message);
    }

    public bool wasEnterPressed(){
        ConsoleKeyInfo cki = Console.ReadKey();
        return ( cki.Key == ConsoleKey.Enter );
    }

    public override void walkActivity(){
        string text = "List as many responses you can to the following prompt:";
        text += "\n --- " + GetRandomElement( _listQuestions ) + " ---\n";
        text += "You may begin in: ";
        Console.Write(text);
        Showtimer(5);
        Console.WriteLine("");
        
        int count = 0;
        startTime();
        Console.Write("> ");

        for (int i = 0; i < 10000; i++){
            // input = Console.Read();
            if ( wasEnterPressed() ){
                count += 1;
                Console.Write("\n> ");
            }

            if ( HasUsedAllSeconds() ){
                break;
            }

        }
        Console.WriteLine($"\nYou listed {count} items!\n");
        

        

        
        // string _ = Console.ReadLine();


    }

    public void ShowQuestion(){

    }
}