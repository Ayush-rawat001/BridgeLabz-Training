using System;
class TypeConversion
{ static void Main(){
//implicit type conversion

int a = 10;
double b = a;
Console.WriteLine(b);

//explicit type conversion

double x = 12.5;
int y = (int)x;
Console.WriteLine(y);

//String to int

string s = "20";
int n = int.Parse(s);
Console.WriteLine(n);

}}
