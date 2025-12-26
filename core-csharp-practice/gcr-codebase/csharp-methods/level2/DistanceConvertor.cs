using System;

public static class UnitConvertor{
    public static double ConvertKmToMiles(double km){
        double km2miles = 0.621371;
        return km * km2miles;
    }

    public static double ConvertMilesToKm(double miles){
        double miles2km = 1.60934;
        return miles * miles2km;
    }

    public static double ConvertMetersToFeet(double meters){
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }

    public static double ConvertFeetToMeters(double feet){
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }
}

class DistanceConvertor{
    static void Main(){
        double v1 = double.Parse(Console.ReadLine());
        double v2 = double.Parse(Console.ReadLine());
        double v3 = double.Parse(Console.ReadLine());
        double v4 = double.Parse(Console.ReadLine());
        Console.WriteLine(UnitConvertor.ConvertKmToMiles(v1));
        Console.WriteLine(UnitConvertor.ConvertMilesToKm(v2));
        Console.WriteLine(UnitConvertor.ConvertMetersToFeet(v3));
        Console.WriteLine(UnitConvertor.ConvertFeetToMeters(v4));
    }
}
