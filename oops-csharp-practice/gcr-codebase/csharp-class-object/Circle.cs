using System;

class RoundShape
{
    double rad;

    public RoundShape(double r)
    {
        rad = r;
    }

    public double FindSurface()
    {
        return 3.14159 * rad * rad;
    }

    public double FindBoundary()
    {
        return 2 * 3.14159 * rad;
    }

    public void PrintResult()
    {
        Console.WriteLine("\n--- Circle Calculation ---");
        Console.WriteLine("Radius        : " + rad + " units");
        Console.WriteLine("Area          : " + FindSurface());
        Console.WriteLine("Circumference : " + FindBoundary());
        Console.WriteLine("--------------------------");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Provide radius value:");
        double r = Convert.ToDouble(Console.ReadLine());

        RoundShape c1 = new RoundShape(r);
        c1.PrintResult();
    }
}
