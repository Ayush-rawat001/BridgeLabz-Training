using System;

class Interest{
    static void Main(){
        double principal = double.Parse(Console.ReadLine());
        double rate = double.Parse(Console.ReadLine());
        double time = double.Parse(Console.ReadLine());

        double interest = CalculateSimpleInterest(principal, rate, time);

        Console.WriteLine("The Simple Interest is " + interest + " for Principal " + principal + ", Rate of Interest " + rate + " and Time " + time);
    }

    static double CalculateSimpleInterest(double principal, double rate, double time){
        return (principal * rate * time) / 100;
    }
}
