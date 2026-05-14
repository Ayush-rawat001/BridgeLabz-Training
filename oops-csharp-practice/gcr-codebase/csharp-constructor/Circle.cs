using System;

class Circle
{
    private double radius;

    public Circle() : this(1) { }// chaining

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public void Print()
    {
        double area = 3.14159 * radius * radius;
        double peri = 2 * 3.14159 * radius;
        Console.WriteLine($"\n[Circle Data]\nRadius: {radius} cm\nArea: {area} cm²\nBoundary: {peri} cm\n");
    }

    public static void Main()
    {
        Circle c1 = new Circle();
        c1.Print();

        Console.WriteLine("input radius:");
        double r = Convert.ToDouble(Console.ReadLine());
        Circle c2 = new Circle(r);
        c2.Print();
    }
}
