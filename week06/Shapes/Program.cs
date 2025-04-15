using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square(4);
        square.SetColor("Red");
        shapes.Add(square);

        Rectangle rectangle = new Rectangle(4, 6);
        rectangle.SetColor("Blue");
        shapes.Add(rectangle);

        Circle circle = new Circle(3);
        circle.SetColor("Green");
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}