// 7. Create a program to swap two numbers
// Hint:
// Create a variable number1 and take user input.
// Create a variable number2 and take user input.
// Swap number1 and number2 and print the swapped output.
// I/P => number1, number2
// O/P => The swapped numbers are ___ and ___

using System;
class Swap{
    static void Main(){
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("The swapped numbers are " + num1 + " and " + num2);
    }
}
