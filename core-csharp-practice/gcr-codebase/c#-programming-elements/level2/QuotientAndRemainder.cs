// 1. Write a program to take 2 numbers and print their quotient and remainder
// Hint: Use division operator (/) for quotient and modulus operator (%) for remainder
// I/P => number1, number2
// O/P => The Quotient is ___ and Remainder is ___ of two numbers ___ and ___

using System;
class QuotientAndRemainder{
    static void Main(){
        int num1=int.Parse(Console.ReadLine());
        int num2=int.Parse(Console.ReadLine());
        int q=num1 / num2;
        int r=num1 % num2;
        Console.WriteLine("The Quotient is " +q+" and Remainder is " +r+ " of two numbers " +num1+ " and " +num2);
    }
}
