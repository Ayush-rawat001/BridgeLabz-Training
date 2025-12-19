// 10. Create a program to divide N number of chocolates among M children.
// Hint:
// Get an integer value from the user for numberOfChocolates and numberOfChildren.
// Find the number of chocolates each child gets and the number of remaining chocolates.
// Display the results.
// I/P => numberOfChocolates, numberOfChildren
// O/P => The number of chocolates each child gets is ___ and the number of remaining chocolates is ___

using System;
class Chocolate{
    static void Main(){
        int Choco= int.Parse(Console.ReadLine());
        int Children = int.Parse(Console.ReadLine());
        int perChild = Choco / Children;
        int remaining= Choco % Children;
        Console.WriteLine("The number of chocolates each child gets is " +perChild+" and the number of remaining chocolates is " +remaining);
    }
}
