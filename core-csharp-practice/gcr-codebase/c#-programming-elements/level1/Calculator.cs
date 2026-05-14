// 11. Write a program to create a basic calculator that can perform addition, subtraction, multiplication, and division. The program should ask for two numbers (floating point) and perform all the operations
// Hint:
// Create a variable number1 and number 2 and take user inputs.
// Perform Arithmetic Operations of addition, subtraction, multiplication, and division and assign the result to a variable and finally print the result
// I/P => number1, number2
// O/P => The addition, subtraction, multiplication and division value of 2 numbers ___ and ___ is ___, ____, ____, and ___

using System;
class Calculator{
static void Main(){
float num1=float.Parse(Console.ReadLine());
float num2=float.Parse(Console.ReadLine());
float sum=num1+num2;
float diff=num1-num2;
float product=num1*num2;
float divide=num1/num2;
Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " +num1 + " and " + num2 + " is " + sum + ", " + diff+ ", " + product + ", and " + divide);
}
}
