using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");

        Console.WriteLine("Wellcome to the Journal Program!");

        Prompt p = new Prompt();

        p.Run();
        
        //*********************************************************************
        // This code uses JSON file format instead of CSV. It can:
        // - Load a JSON file
        // - Save to a JSON file
        // - Avoid writing the same entries in the loaded file, by turning
        //    `_fileHasBeenLoaded` to True and so it can overwrite all content
        // - Avoid closing the program if entries are not saved, by turning
        //    `_areEntriesSaved` to True
        //*********************************************************************


    }
}