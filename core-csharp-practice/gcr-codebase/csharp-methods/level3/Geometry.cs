using System;

class Geometry{
    static void Main(){
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double distance = EuclideanDistance(x1, y1, x2, y2);
        Console.WriteLine(distance);

        double[] line = LineEquation(x1, y1, x2, y2);
        Console.WriteLine(line[0] + " " + line[1]); 
    }

  
    public static double EuclideanDistance(double x1, double y1, double x2, double y2){
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

   
    public static double[] LineEquation(double x1, double y1, double x2, double y2){
        double m;
        if (x2 - x1 == 0) {
            m = double.PositiveInfinity;
        }
        else{
            m = (y2 - y1) / (x2 - x1);
        }
        double b = y1 - m * x1;
        return new double[] { m, b };
    }
}
