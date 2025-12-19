// 10. Write a program that takes your height in centimeters and converts it into feet and inches
// Hint: 1 foot = 12 inches and 1 inch = 2.54 cm
// I/P => height
// O/P => Your Height in cm is ___ while in feet is ___ and inches is ___


using System;
class HeightConversion{
static void Main(){
double heightInCm=Convert.ToDouble(Console.ReadLine());
double totalInches = heightInCm / 2.54;
int feet = (int)(totalInches / 12);
double inches = totalInches % 12; 
Console.WriteLine("Your Height in cm is "+heightInCm+" while in feet is "+feet+" and inches is "+inches);
    }
}