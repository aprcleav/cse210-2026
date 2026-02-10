using System;
using System.Drawing;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square("blue", 10);
        Rectangle r = new Rectangle("green", 11, 30);
        Circle c = new Circle("pink", 6.62);
        List<Shape> shapes = new List<Shape>();
        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The area of the {color} shape is {area}");

        }
        // string color = s.GetColor();
        // double area = s.GetArea();
        // Console.WriteLine($"The area of the {color} square is {area}");
    }
}