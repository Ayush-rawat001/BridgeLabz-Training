// 8. Create a program to convert distance in kilometers to miles.
// Hint:
// Create a variable km and assign type as double as in double km;
// Create Scanner Object to take user input from Standard Input that is the Keyboard as in Scanner input = new Scanner(System.in);
// Use Scanner Object to take user input for km as in km = input.nextInt();
// Use 1 mile = 1.6 km formulae to calculate miles and show the output
// I/P => km
// O/P => The total miles is ___ mile for the given ___ km

using System;
class KmToMil_2{
    static void Main(){
        double input=Convert.ToDouble(Console.ReadLine());
        double res=input*1.6;
        Console.WriteLine("The total miles is "+res+" mile for the given "+input+"km"); 
    }
}