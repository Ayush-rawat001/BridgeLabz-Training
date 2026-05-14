// 6. Create a program to find the total income of a person by taking salary and bonus from the user
// Hint:
// Create a variable named salary and take user input.
// Create another variable bonus and take user input.
// Compute income by adding salary and bonus and print the result.
// I/P => salary, bonus
// O/P => The salary is INR ___ and bonus is INR ___. Hence Total Income is INR ___
using System;
class TotalIncomeCalculator{
    static void Main(){
        double s= double.Parse(Console.ReadLine());
        double b= double.Parse(Console.ReadLine());
        double total= s+b;
        Console.WriteLine("The salary is INR " + s+" and bonus is INR " + b+". Hence Total Income is INR " + total);
    }
}
