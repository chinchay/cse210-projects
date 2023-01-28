public class Prompt {
    public string _filename = "";


    public string showOptions(){
        string question = "Please select one of the following choices:";
        string options  = "1. Write\n2. Display\n3. Load\n4. Save\n5. Quit";
        string prompt   = "What would you like to do? ";
        Console.WriteLine( question );
        Console.WriteLine( options );
        Console.Write( prompt );
        string option = Console.ReadLine();
        return option;
    }

    public int handleOptions( string option, JournalBook book ){
        

        switch (option){
            case "1":
                book.write();
                return 10;

            case "2":
                book.display();
                return 20;

            case "3":
                book.loadFromJSON();
                return 30;
                
            case "4":
                book.saveToJSON();
                return 40;

            case "5":
                book.checkAllIsSaved();
                return 50;

            default:
                return -1;

        }
    }

    public void run(){
        string option = "";
        int count = 0;
        int maxIterations = 5;

        JournalBook book = new JournalBook();
        
        do {
            option = showOptions();

            int ans = handleOptions( option, book );
            // Console.WriteLine( ans.ToString() );

            count += 1;

        } while ( (option != "5") && (count < maxIterations) );

        

        
        
    }
}