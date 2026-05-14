using System;

class Trig
{
    static void Main()
    {
        double angleDegrees = double.Parse(Console.ReadLine());
        double[] trigValues = CalculateTrigFunctions(angleDegrees);

        Console.WriteLine("Sine: " + trigValues[0]);
        Console.WriteLine("Cosine: " + trigValues[1]);
        Console.WriteLine("Tangent: " + trigValues[2]);
    }

    public static double[] CalculateTrigFunctions(double angleDeg)
    {
        double angleRad = angleDeg * Math.PI / 180.0;
        double sineValue = Math.Sin(angleRad);
        double cosineValue = Math.Cos(angleRad);
        double tangentValue = Math.Tan(angleRad);

        return new double[] { sineValue, cosineValue, tangentValue };
    }
}
