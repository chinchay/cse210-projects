using System;

class Program
{
    static void Main(string[] args)
    {

        int iMax  = 10;
        int i     = 0;
        int guess = 0;
        string want2play = "yes";
        do{
            i = 0;
            Console.WriteLine("What is the magic number?");
            // int magic = int.Parse( Console.ReadLine() );
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1, 101);

            do {
                Console.WriteLine("What is your guess?");
                guess = int.Parse( Console.ReadLine() );

                if (magic < guess) {
                    Console.WriteLine("Lower");
                } else if (magic > guess) {
                    Console.WriteLine("Higher");
                } else {
                    Console.WriteLine("You guessed it!");
                }
                i += 1;
            } while ( (magic != guess) && (i < iMax) );

            Console.WriteLine($"You tried {i} attempts!");
            Console.WriteLine("Do you want to play again?");
            want2play = Console.ReadLine();
        } while (want2play == "yes");


    }
}