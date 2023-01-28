public class JournalEntry{
    // Example how to read JSON found here:
    // https://www.educative.io/answers/how-to-read-a-json-file-in-c-sharp
    public string date { get; set; }
    public string question { get; set; }
    public string answer { get; set; }

    public JournalEntry(string date, string question, string answer){
        this.date     = date;
        this.question = question;
        this.answer   = answer;
    }

    public void Display(){
        Console.WriteLine( $"Date: {date} - Prompt: {question}" );
        Console.WriteLine( $"{answer}\n" );
    }
}