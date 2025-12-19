// 12. Write a program that takes the base and height to find the area of a triangle in square inches and square centimeters
// Hint: Area of a Triangle is ½ * base * height
// I/P => base, height
// O/P => Your Height in cm is ___ while in feet is ___ and inches is ___

using System;
class AreaOfTriangle{
    static void Main(){
        int b=int.Parse(Console.ReadLine());
        int height=int.Parse(Console.ReadLine());
        double  areaInCm=0.5*b*height;
        double areaInInch=0.155*areaInCm;
        Console.WriteLine("your area in cm square is "+areaInCm+" and in square inches "+areaInInch);
          }
}