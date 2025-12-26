using System;

class Quadratic{
    static void Main(){
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double[] r = GetRoots(a, b, c);

        if (r.Length == 2)
            Console.WriteLine(r[0] + " " + r[1]);
        else if (r.Length == 1)
            Console.WriteLine(r[0]);
    }

    static double[] GetRoots(double a, double b, double c){
        double d = Math.Pow(b, 2) - 4 * a * c;

        if (d > 0){
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return new double[] { x1, x2 };
        }
        else if (d == 0){
            double x = -b / (2 * a);
            return new double[] { x };
        }
        return new double[0];
    }
}
