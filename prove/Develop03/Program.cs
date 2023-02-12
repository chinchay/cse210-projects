using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");


        string book = "Proverbs";
        int chapter = 3;
        int verse_start = 5;
        int verse_end = 6;

        Reference r = new Reference(book, chapter, verse_start, verse_end);
        
        Scripture s = new Scripture(r);

        s.String2Word();




    }
}