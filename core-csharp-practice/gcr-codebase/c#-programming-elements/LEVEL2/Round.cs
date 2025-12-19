// 9. An athlete runs in a triangular park with sides provided as input by the user in meters. If the athlete wants to complete a 5 km run, then how many rounds must the athlete complete?
// Hint:
// The perimeter of a triangle is the addition of all sides.
// Rounds = distance / perimeter
// I/P => side1, side2, side3
// O/P => The total number of rounds the athlete will run is ___ to complete 5 km

using System;
class Round{
    static void Main(){
        double s1 = double.Parse(Console.ReadLine());
        double s2 = double.Parse(Console.ReadLine());
        double s3 = double.Parse(Console.ReadLine());
        double p= s1+s2+s3;
        double d = 5000; // 5 km =5000 meters
        double rounds = d/p;
        Console.WriteLine("The total number of rounds the athlete will run is " +rounds +" to complete 5 km");
    }
}
