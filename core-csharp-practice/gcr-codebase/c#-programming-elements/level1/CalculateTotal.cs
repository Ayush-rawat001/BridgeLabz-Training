// 15. Write a program to input the unit price of an item and the quantity to be bought. Then, calculate the total price.
// Hint: NA
// I/P => unitPrice, quantity
// O/P => The total purchase price is INR ___ if the quantity ___ and unit price is INR ___

using System;
class CalculateTotal{
    static void Main(){
     double unit=double.Parse(Console.ReadLine());
     int qty=int.Parse(Console.ReadLine());
     double tp=unit*qty;
    Console.WriteLine("The total purchase price is INR " +tp+" if the quantity " +qty+" and unit price is INR "+unit);
    }
}
