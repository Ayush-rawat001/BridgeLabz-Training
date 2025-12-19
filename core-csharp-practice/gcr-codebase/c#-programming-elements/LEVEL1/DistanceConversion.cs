// 14. Write a program to find the distance in yards and miles for the distance provided by the user in feet
// Hint: 1 mile = 1760 yards and 1 yard is 3 feet
// I/P => distanceInFeet
// O/P => Your Height in cm is ___ while in feet is ___ and inches is ___

using System;
class DistanceConversion{
    static void Main(){
       double F = double.Parse(Console.ReadLine());
       double Y = F/3;
       double M = Y/1760;
       Console.WriteLine("The distance in feet is " + F +" while in yards is " + Y +" and in miles is " + M);
    }
}
