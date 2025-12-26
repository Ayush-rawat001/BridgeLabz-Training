using System;

class TriangularRun{
    static void Main(){
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double side3 = double.Parse(Console.ReadLine());

        int rounds = CalculateRounds(side1, side2, side3);
        Console.WriteLine(rounds);
    }

    static int CalculateRounds(double a, double b, double c){
        double perimeter = a + b + c; 
        double totalDistance = 5000; 
        return (int)Math.Ceiling(totalDistance / perimeter);
    }
}
