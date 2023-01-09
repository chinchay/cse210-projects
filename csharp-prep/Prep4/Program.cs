using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 0;
        List<int> listNumbers = new List<int>();

        // int sum = 0;
        int i = 0;
        // int largest = 0;
        // double average = 0;
        double smallPositive = 0;

        do {
            Console.Write("Enter number: ");
            number = int.Parse( Console.ReadLine() );
            

            i += 1;

            // if (i != 1) {
            //     if (number > largest) {
            //         largest = number;
            //     }
            // } else {
            //     largest = number;
            // }

            if (i != 1) {
                if ( (number < smallPositive) && (number > 0) ) {
                    smallPositive = number;
                }
            } else {
                smallPositive = number;
            }

            // sum += number;
            if (number != 0){
                listNumbers.Add(number);
            }

        } while (number != 0);

        // average = 1.0 * sum / (i - 1);
        // Console.WriteLine($"The sum is: {sum}");
        // Console.WriteLine($"The average is: {average}");
        // Console.WriteLine($"The largest number is: {largest}");
        // Console.WriteLine($"The smallest positive number is: {smallPositive}");
        // Console.WriteLine("The sorted list is:");


        Console.WriteLine($"The sum is: {listNumbers.Sum()}");
        Console.WriteLine($"The average is: {listNumbers.Average()}");
        Console.WriteLine($"The largest number is: {listNumbers.Max()}");
        Console.WriteLine($"The smallest positive number is: {smallPositive}");
        Console.WriteLine("The sorted list is:");
        
        listNumbers.Sort();
        foreach ( int j in listNumbers ) {
            Console.WriteLine($"{j}");
        }

    }
}