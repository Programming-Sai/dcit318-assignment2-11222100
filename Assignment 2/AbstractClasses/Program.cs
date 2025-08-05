using System;

abstract class Shape
{
    // Abstract method (must be implemented by derived classes)
    public abstract double GetArea();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Implement GetArea() for Circle
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Implement GetArea() for Rectangle
    public override double GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape myCircle = new Circle(5);
        Shape myRectangle = new Rectangle(4, 6);

        Console.WriteLine($"Area of Circle: {myCircle.GetArea():F2}");
        Console.WriteLine($"Area of Rectangle: {myRectangle.GetArea():F2}");
    }
}
