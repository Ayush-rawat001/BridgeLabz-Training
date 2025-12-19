// 13. Write a program to find the side of the square whose perimeter you read from user
// Hint: Perimeter of Square is 4 times side
// I/P => perimeter
// O/P => The length of the side is ___ whose perimeter is ____

using System;
class LengthOfSquare{
    static void Main(){
        int p=int.Parse(Console.ReadLine());
        float side=(float)p/4;
        Console.WriteLine("The length of the side is "+side+" whose perimeter is "+p);
    }
}