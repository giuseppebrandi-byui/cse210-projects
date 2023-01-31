using System;

class Program
{

    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("red", 10));
        shapes.Add(new Rectangle("yellow", 10, 20));
        shapes.Add(new Circle("blue", 6));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}