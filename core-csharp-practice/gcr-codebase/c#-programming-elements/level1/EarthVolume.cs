// 7. Write a Program to compute the volume of Earth in km^3 and miles^3
// Hint: Volume of a Sphere is (4/3) * pi * r^3 and radius of earth is 6378 km
// O/P => The volume of earth in cubic kilometers is ____ and cubic miles is ____



using System;
class EarthVolume{
static void Main(){
int radiusInKm=6378;
double pi=3.14;
double volumeInKm =(4.0 / 3.0)*pi*radiusInKm*radiusInKm*radiusInKm;
 double radiusInMil=radiusInKm*0.621371;
double volumeInMiles = (4.0 / 3.0) *pi*radiusInMil*radiusInMil*radiusInMil;
Console.WriteLine("The volume of earth in cubic kilometers is " + volumeInKm +" and cubic miles is " + volumeInMiles);
    }
}
