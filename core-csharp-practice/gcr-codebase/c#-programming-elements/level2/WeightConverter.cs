// 12. Create a program to convert weight in pounds to kilograms.
// Hint:
// 1 pound = 2.2 kg
// I/P => weight (in pounds)
// O/P => The weight of the person in pounds is ___ and in kg is ___

using System;
class WeightConverter{
    static void Main(){
     double Pounds = double.Parse(Console.ReadLine());
     double Kg = Pounds / 2.2;
     Console.WriteLine("The weight of the person in pounds is " +Pounds+" and in kg is "+Kg);
    }
}
