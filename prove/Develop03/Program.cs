using System;

class Program
{
    static void Main(string[] args)
    {
        string book = "Proverbs";
        int chapter = 3;
        int verse_start = 5;
        int verse_end = 6;

        Reference r = new Reference(book, chapter, verse_start, verse_end);
        
        Scripture s = new Scripture(r);
        s.String2Word();
        s.Display();

        bool isCompletelyHidden = false;
        int countMax = 20;
        int count = 0;

        while (   (count < countMax)
                & (!isCompletelyHidden)
                & (Console.ReadLine() != "quit") ) {
            //
            s.HideWords();
            s.Display();
            isCompletelyHidden = s.IsCompletelyHidden();
        }

    }
}