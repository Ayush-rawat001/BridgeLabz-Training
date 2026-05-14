using System;

public static class UnitConvertor{
    public static double ConvertYardsToFeet(double yards){
        double yards2feet = 3;
        return yards * yards2feet;
    }

    public static double ConvertFeetToYards(double feet){
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }

    public static double ConvertMetersToInches(double meters){
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }

    public static double ConvertInchesToMeters(double inches){
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }

    public static double ConvertInchesToCm(double inches){
        double inches2cm = 2.54;
        return inches * inches2cm;
    }
}

class MeasurementConvertor{
    static void Main(){
        double yards = double.Parse(Console.ReadLine());
        double feet = double.Parse(Console.ReadLine());
        double meters = double.Parse(Console.ReadLine());
        double inches = double.Parse(Console.ReadLine());
        double inches2 = double.Parse(Console.ReadLine());

        Console.WriteLine(UnitConvertor.ConvertYardsToFeet(yards));
        Console.WriteLine(UnitConvertor.ConvertFeetToYards(feet));
        Console.WriteLine(UnitConvertor.ConvertMetersToInches(meters));
        Console.WriteLine(UnitConvertor.ConvertInchesToMeters(inches));
        Console.WriteLine(UnitConvertor.ConvertInchesToCm(inches2));
    }
}
