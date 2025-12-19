// 11. Write a program to input the Principal, Rate, and Time values and calculate Simple Interest.
// Hint:
// Simple Interest = (Principal * Rate * Time) / 100
// I/P => principal, rate, time
// O/P => The Simple Interest is ___ for Principal ___, Rate of Interest ___ and Time ___

using System;
class SimpleInterest{
    static void Main(){
    double principal=double.Parse(Console.ReadLine());
    double rate=double.Parse(Console.ReadLine());
    double time=double.Parse(Console.ReadLine());
    double SI=(principal * rate * time)/100;
    Console.WriteLine("The Simple Interest is " +SI+" for Principal " +principal+", Rate of Interest " +rate+" and Time " +time);
    }
}
