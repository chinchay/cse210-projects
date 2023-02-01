using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");

        // Constructors
        Console.WriteLine("testing constructors");
        Fraction f = new Fraction();
        Console.WriteLine( f.GetFractionString() );
        Console.WriteLine( f.DecimalValue().ToString() );

        Fraction g = new Fraction(5);
        Console.WriteLine( g.GetFractionString() );
        Console.WriteLine( g.DecimalValue() );

        Fraction h = new Fraction(6, 7);
        Console.WriteLine( h.GetFractionString() );
        Console.WriteLine( h.DecimalValue().ToString() );

        // Setters and getters
        Console.WriteLine("\ntesting setters and getters");
        h.SetTop(9);
        h.SetBottom(10);
        Console.WriteLine( h.GetTop().ToString() );
        Console.WriteLine( h.GetBottom().ToString() );

        // GetFractionString and GetDecimalValue
        Console.WriteLine("\nMore testing GetFractionString() and GetDecimalValue()");
        Fraction i = new Fraction(1);
        Console.WriteLine( i.GetFractionString() );
        Console.WriteLine( i.DecimalValue() );
        Fraction j = new Fraction(5);
        Console.WriteLine( j.GetFractionString() );
        Console.WriteLine( j.DecimalValue() );
        Fraction k = new Fraction(3, 4);
        Console.WriteLine( k.GetFractionString() ); 
        Console.WriteLine( k.DecimalValue() );  
        Fraction l = new Fraction(1, 3);
        Console.WriteLine( l.GetFractionString() ); 
        Console.WriteLine( l.DecimalValue() );            

        

 

    }
}