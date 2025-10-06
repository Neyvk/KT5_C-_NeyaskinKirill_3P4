using System;

interface IShape
{
    double Area { get; }
    double Perimeter { get; }
}

class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

     public double Area
    {
        get { return Math.PI * Math.Pow(Radius, 2); }
    }
    public double Perimeter
    {
        get { return 2 * Math.PI * Radius; }
    }
}

class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Area
    {
        get { return Width * Height; }
    }
    public double Perimeter
    {
        get { return 2 * (Width + Height); }
    }
}

class Triangle : IShape
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Triangle(double a, double b, double c)
    {
        A = a; B = b; C = c;
    }

    public double Perimeter
    {
        get { return A + B + C; }
    }

    public double Area
    {
        get
        {
            double s = Perimeter / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }
    }
}

class Program2
{
    static void Main()
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);
        Triangle triangle = new Triangle(3, 4, 5);

        Console.WriteLine($"Круг: площадь = {circle.Area:F2}, периметр = {circle.Perimeter:F2}");
        Console.WriteLine($"Прямоугольник: площадь = {rectangle.Area}, периметр = {rectangle.Perimeter}");
        Console.WriteLine($"Треугольник: площадь = {triangle.Area:F2}, периметр = {triangle.Perimeter}");
    }
}
