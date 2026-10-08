using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine();


     // Testing the Square class

        Square square = new Square("Red", 5);


        Console.WriteLine("Testing of Square");
        Console.WriteLine($"Color: {square.GetColor()}");
        Console.WriteLine($"Side: {square.GetArea()}");
        Console.WriteLine();


        // Testing the Rectangle

        Rectangle rectangle = new Rectangle("Green", 6, 4);


        Console.WriteLine("Testing of Rectangle");
        Console.WriteLine($"Color: {rectangle.GetColor()}");
        Console.WriteLine($"Side: {rectangle.GetArea()}");
        Console.WriteLine();


        // Testing the Circle

        Circle circle = new Circle("Blue", 3);


        Console.WriteLine("Testing of Circle");
        Console.WriteLine($"Color: {circle.GetColor()}");
        Console.WriteLine($"Side: {circle.GetArea():F2}");
        Console.WriteLine();



        List<Shape> shapes = new List<Shape>();


        Square square1 = new Square("Blue", 4);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("Black", 5, 3);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("Yellow", 3);
        shapes.Add(circle1);


        Console.WriteLine("List of forms: ");


        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Side: {shape.GetArea():F2}");

        }

        

    }
}