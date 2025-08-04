using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes= new List<Shape>();
        _shapes.Add(new Square("Red", 2));
        _shapes.Add(new Rectangle(5, 6, "green"));
        _shapes.Add(new Circle(5, "Yellow"));

        foreach (Shape shape in _shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");  
        }
    }
}