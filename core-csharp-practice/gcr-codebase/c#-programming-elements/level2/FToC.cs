// 5. Write a TemperatureConversion program, given the temperature in Fahrenheit as input that outputs the temperature in Celsius
// Hint:
// Create a fahrenheit variable and take the user's input.
// Use the formula: Fahrenheit to Celsius: (°F − 32) x 5/9 = °C
// Assign the result to celsiusResult and print the result.
// I/P => fahrenheit
// O/P => The ___ Fahrenheit is ___ Celsius

using System;
class FToC{
    static void Main(){
        double f= double.Parse(Console.ReadLine());
        double c= (f- 32) * 5 / 9;
         Console.WriteLine("The " + f+ " Fahrenheit is " +c+ " Celsius");
    }
}
