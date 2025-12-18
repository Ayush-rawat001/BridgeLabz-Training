using System;

class CylinderVolume{
static void Main(){
double r=double.Parse(Console.ReadLine());
double h=double.Parse(Console.ReadLine());
double v=3.14*r*r*h;
Console.WriteLine(v);
}
}