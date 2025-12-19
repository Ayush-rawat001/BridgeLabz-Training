// 16. Create a program to find the maximum number of handshakes among N number of students.
// Hint:
// Get integer input for numberOfStudents variable.
// Use the combination = (n * (n - 1)) / 2 formula to calculate the maximum number of possible handshakes.
// Display the number of possible handshakes.

using System;
class Handshake{
  static void Main(){
        int numOfStud=int.Parse(Console.ReadLine());
        int totalHandshakes=(numOfStud*(numOfStud-1))/2;
        Console.WriteLine("The maximum number of handshakes among "+numOfStud + " students is " + totalHandshakes);
    }
}
