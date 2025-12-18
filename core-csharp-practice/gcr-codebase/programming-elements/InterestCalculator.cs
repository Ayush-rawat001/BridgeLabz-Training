using System;
class InterestCalculator{
static void Main(){
double p = double.Parse(Console.ReadLine());
double r = double.Parse(Console.ReadLine());
double t = double.Parse(Console.ReadLine());
double si = (p*r*t)/100;
Console.WriteLine(si);
}
}