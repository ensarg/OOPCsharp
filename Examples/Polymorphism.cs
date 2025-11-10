namespace OOPExamples.Examples;

/// <summary>
/// Demonstrates Polymorphism - the ability of objects to take multiple forms,
/// allowing the same method to behave differently based on the object type.
/// </summary>

// Base class for shapes
public class Shape
{
    public string Color { get; set; }

    public Shape(string color)
    {
        Color = color;
    }

    // Virtual method - can be overridden in derived classes
    public virtual double CalculateArea()
    {
        return 0;
    }

    public virtual void Display()
    {
        Console.WriteLine($"This is a {Color} shape.");
    }
}

// Circle class
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(string color, double radius) : base(color)
    {
        Radius = radius;
    }

    // Override the CalculateArea method
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override void Display()
    {
        Console.WriteLine($"Circle - Color: {Color}, Radius: {Radius}");
    }
}

// Rectangle class
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(string color, double width, double height) : base(color)
    {
        Width = width;
        Height = height;
    }

    // Override the CalculateArea method
    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override void Display()
    {
        Console.WriteLine($"Rectangle - Color: {Color}, Width: {Width}, Height: {Height}");
    }
}

// Triangle class
public class Triangle : Shape
{
    public double BaseLength { get; set; }
    public double Height { get; set; }

    public Triangle(string color, double baseLength, double height) : base(color)
    {
        BaseLength = baseLength;
        Height = height;
    }

    // Override the CalculateArea method
    public override double CalculateArea()
    {
        return 0.5 * BaseLength * Height;
    }

    public override void Display()
    {
        Console.WriteLine($"Triangle - Color: {Color}, Base: {BaseLength}, Height: {Height}");
    }
}
