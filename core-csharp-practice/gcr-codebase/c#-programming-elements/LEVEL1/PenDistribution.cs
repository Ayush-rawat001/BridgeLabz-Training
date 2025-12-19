// 5. Suppose you have to divide 14 pens among 3 students equally. Write a program to find how many pens each student will get if the pens must be divided equally. Also, find the remaining non-distributed pens.
// Hint:
// Use Modulus Operator (%) to find the reminder.
// Use Division Operator to find the Quantity of pens
// I/P => NONE
// O/P => The Pen Per Student is ___ and the remaining pen not distributed is ___


using System;
class PenDistribution{
static void Main(){
int pens=14;
int s=3;
int penPerPerson=pens/s;
int remaining=pens%s;
Console.WriteLine("The Pen Per Student is " + pensPerPerson +" and the remaining pen not distributed is " + remaining);
    }
}
