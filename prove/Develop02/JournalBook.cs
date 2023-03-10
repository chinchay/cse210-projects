using System.IO;
using System.Text.Json;

public class JournalBook{
    public List<JournalEntry> _listEntry = new List<JournalEntry>();
    public string _filename = "";
    public List<string> _listQuestion;
    public string _username;
    public bool _areEntriesSaved = false;
    public bool _fileHasBeenLoaded = false;

//    List<string> _listQuestion = new List<string>(); errors appear in the consructor, so I commented it out


    public string ReadFile(string filename){
        string text = "";

        try{
            // text = File.ReadAllText( @"sample.json" ); //_filename
            text = File.ReadAllText( @_filename );
        } catch {
            Console.WriteLine("File not found");
        }

        return text;
    }

    // public List<JournalEntry> getListEntries( string jsonText ){
    public void UpdateListEntries( string jsonText ){
        // Example how to read JSON found here:
        // https://www.educative.io/answers/how-to-read-a-json-file-in-c-sharp

        try{
            _listEntry = 
                JsonSerializer.Deserialize<List<JournalEntry>>( jsonText );
        } catch {
            Console.WriteLine("Error while converting file content to JSON");
        }
    }


    public string PromptFilename(){
        Console.WriteLine("What is the filename?");
        return Console.ReadLine();
    }


    public void LoadFromJSON(){
        CheckFilename();
        string text = ReadFile(_filename);
        UpdateListEntries(text);
        _fileHasBeenLoaded = true;
    }

    // errors arise when defining the constructor this way, why?
    // public JournalBook{
    //     // This constructor will initialize the questions:
    //     string q1 = "Who was the most interesting person I interacted with today?";
    //     string q2 = "What was the best part of my day?";
    //     string q3 = "How did I see the hand of the Lord in my life today?";
    //     string q4 = "What was the strongest emotion I felt today?";
    //     string q5 = "If I had one thing I could do ever today, what would it be?";
        
    //     string[] questions = {q1, q2, q3, q4, q5};

    //     _listQuestion.Add(q1);

    //     _listQuestion.Add(q1);
    // }

    public string GetRandomQuestion(){
        
        string q1 = "Who was the most interesting person I interacted with today?";
        string q2 = "What was the best part of my day?";
        string q3 = "How did I see the hand of the Lord in my life today?";
        string q4 = "What was the strongest emotion I felt today?";
        string q5 = "If I had one thing I could do ever today, what would it be?";

        List<string> listQuestion = new List<string>{q1, q2, q3, q4, q5};
        Random random = new Random();
        return listQuestion[ random.Next( listQuestion.Count ) ];
    }


    public void Write(){
        string question = GetRandomQuestion();
        Console.WriteLine(question);
        string answer = Console.ReadLine();

        JournalEntry j = new JournalEntry(question, answer );
        _listEntry.Add(j);
        _areEntriesSaved = false;
    }


    public void Display(){
        foreach (JournalEntry e in _listEntry) {
            e.Display();
        }
    }

    public void Save2file(string text, string filename) {
        using (StreamWriter f = new StreamWriter(filename) ) {
            f.WriteLine(text); 
        }
    }


    public void CheckFilename(){
        if (_filename == "") {
            Console.Write("What is the file name? ");
            _filename = Console.ReadLine();
        }
    }

    public void CheckFileContent(){
        if (_fileHasBeenLoaded == false) {
            if (File.Exists(_filename)) {
                List<JournalEntry> tempList = new List<JournalEntry>();
                tempList = _listEntry;
                LoadFromJSON(); // this will overwrite _listEntry

                // now add tempList to _listEntry:
                foreach (JournalEntry j in tempList) {
                        _listEntry.Add(j);
                }
            }
        }
    }

    public void SaveToJSON(){
        CheckFilename();
        CheckFileContent();

        string json = JsonSerializer.Serialize(_listEntry);
        // Console.WriteLine(json);
        
        Save2file(json, _filename);
        _areEntriesSaved = true;
    }


    public void CheckAllIsSaved() {
        if (_areEntriesSaved == false){
            SaveToJSON();
        }
    }
}