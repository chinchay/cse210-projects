using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What was the grade percentage?");
        int grade = int.Parse( Console.ReadLine() );

        string letter;
        if (grade >= 90){
            // Console.WriteLine("A");
            letter = "A";
        }
        else if (grade >= 80){
            // Console.WriteLine("B");
            letter = "B";
        }
        else if (grade >= 70){
            // Console.WriteLine("C");
            letter = "C";
        }
        else if (grade >= 60){
            // Console.WriteLine("D");
            letter = "D";
        }
        else{
            // Console.WriteLine("F");
            letter = "F";
        }
        
        int remainder = grade % 10;
        string sign = "";
        if (remainder < 3){
            if (letter != "F"){
                sign = "-";
            }
        } else if (remainder > 7){
            if ( (letter != "A") && (letter != "F") ){
                sign = "+";
            }
        }

        Console.WriteLine(letter + sign);



        if (grade > 70){
            Console.WriteLine("user passed the course. Congratulations!");

        }
        else{
            Console.WriteLine("Next time will be better!");
        }

    }
}