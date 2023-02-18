using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");

        Assignment a = new Assignment("Samuel Bennett", "Multiplication");
        string text = a.GetSummary();
        Console.WriteLine(text);

        MathAssignment b = new MathAssignment("Roberto Rodriguez", "Fractions",
        "7.3", "8-19");
        string studentInfo = b.GetSummary();
        string mathInfo    = b.GetHomeworkList();
        Console.WriteLine(studentInfo);
        Console.WriteLine(mathInfo);

        WritingAssignment c = new WritingAssignment("Mary Waters",
        "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine( c.GetSummary() );
        Console.WriteLine( c.GetWritingInformation() );
        
    }
}