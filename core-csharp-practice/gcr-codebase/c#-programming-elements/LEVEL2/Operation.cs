// 2. Write an IntOperation program by taking a, b, and c as input values and print the following integer operations: a + b * c, a * b + c, c + a / b, and a % b + c. Please also understand the precedence of the operators.
// Hint:
// Create variables a, b, and c of int data type.
// Take user input for a, b, and c.
// Compute the 3 integer operations and assign results to variables.
// Finally, print the results and understand operator precedence.
// I/P => a, b, c
// O/P => The results of Int Operations are ___, ___, and ___

using System;
class Operation{
    static void Main(){
        int a= int.Parse(Console.ReadLine());
        int b= int.Parse(Console.ReadLine());
        int c= int.Parse(Console.ReadLine());
        int res1 = a+b*c;       
        int res2 = a*b+c;       
        int res3 = c+a/b;      
        int res4 = a%b+c;       
        Console.WriteLine("The results of Int Operations are: " +res1 + ", " + res2 + ", " + res3 + ", " + res4);
    }
}
