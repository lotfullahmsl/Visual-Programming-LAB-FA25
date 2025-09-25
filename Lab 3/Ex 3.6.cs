using System;

class Circle
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public double Area()
    {
        return Math.PI * radius * radius;
    }

    public double Circumference()
    {
        return 2 * Math.PI * radius;
    }
}

class Exercise3_6
{
    static void Main(string[] args)
    {
        Console.Write("Enter radius of circle: ");
        double r = double.Parse(Console.ReadLine());

        Circle c = new Circle(r);

        Console.WriteLine("Area: " + c.Area());
        Console.WriteLine("Circumference: " + c.Circumference());

        Console.ReadLine();
    }
}
