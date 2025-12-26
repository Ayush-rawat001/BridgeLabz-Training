using System;

class Wind{
    static void Main(){
        double temperature = double.Parse(Console.ReadLine());
        double windSpeed = double.Parse(Console.ReadLine());

        double windChill = CalculateWindChill(temperature, windSpeed);
        Console.WriteLine(windChill);
    }

    public static double CalculateWindChill(double temperature, double windSpeed){
        return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
    }
}
