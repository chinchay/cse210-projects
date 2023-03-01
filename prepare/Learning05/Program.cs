using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        Square s = new Square("red", 3.0);
        Console.WriteLine("area of square: " +  s.GetArea().ToString() );

        Circle c = new Circle("green", 1.0);
        Console.WriteLine("area of circle: " + c.GetArea().ToString());

        Rectangle r = new Rectangle("blue", 2.0, 3.0);
        Console.WriteLine("area of rectangle: " + r.GetArea().ToString());

        List<Shape> listShape = new List<Shape>();
        listShape.Add(s);
        listShape.Add(c);
        listShape.Add(r);
        foreach( Shape shape in listShape ){
            Console.WriteLine( "color is: " + shape.GetColor() + ", and area is: " + shape.GetArea().ToString() );
        }
        
    }
}