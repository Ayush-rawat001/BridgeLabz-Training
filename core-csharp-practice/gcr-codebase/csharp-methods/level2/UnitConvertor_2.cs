using System;

public static class UnitConvertor{
    public static double ConvertFahrenheitToCelsius(double Fahrenheit){
        return (Fahrenheit - 32) * 5 / 9;
    }

    public static double ConvertCelsiusToFahrenheit(double celsius){
        return (celsius * 9 / 5) + 32;
    }

    public static double ConvertPoundsToKg(double pounds){
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    public static double ConvertKgToPounds(double kg){
        double kilograms2pounds = 2.20462;
        return kg * kilograms2pounds;
    }

    public static double ConvertGallonsToLiters(double gallons){
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    public static double ConvertLitersToGallons(double liters) {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }
}

class UnitConvertor_2{
    static void Main(){
        double f = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        double k = double.Parse(Console.ReadLine());
        double g = double.Parse(Console.ReadLine());
        double l = double.Parse(Console.ReadLine());

        Console.WriteLine(UnitConvertor.ConvertFahrenheitToCelsius(f));
        Console.WriteLine(UnitConvertor.ConvertCelsiusToFahrenheit(c));
        Console.WriteLine(UnitConvertor.ConvertPoundsToKg(p));
        Console.WriteLine(UnitConvertor.ConvertKgToPounds(k));
        Console.WriteLine(UnitConvertor.ConvertGallonsToLiters(g));
        Console.WriteLine(UnitConvertor.ConvertLitersToGallons(l));
    }
}
