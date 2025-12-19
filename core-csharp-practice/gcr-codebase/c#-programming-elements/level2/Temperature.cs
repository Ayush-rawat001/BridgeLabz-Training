// 4. Write a TemperatureConversion program, given the temperature in Celsius as input that outputs the temperature in Fahrenheit
// Hint:
// Create a celsius variable and take the temperature as user input.
// Use the formula: Celsius to Fahrenheit: (°C × 9/5) + 32 = °F
// Assign the result to fahrenheitResult and print the result.
// I/P => celsius
// O/P => The ___ Celsius is ___ Fahrenheit

using System;
class Temperature{
    static void Main(){
       double c= double.Parse(Console.ReadLine());
       double f= (c* 9 / 5) + 32;
 Console.WriteLine( "The " + c+ " Celsius is " + f+ " Fahrenheit");
    }
}
