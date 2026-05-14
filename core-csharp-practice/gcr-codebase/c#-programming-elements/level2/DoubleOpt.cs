// 3. Similarly, write the DoubleOpt program by taking double values and doing the same operations.
// I/P => a, b, c
// O/P => The results of Double Operations are ___, ___, and ___

using System;
class DoubleOpt{
    static void Main(){
        double a= double.Parse(Console.ReadLine());
        double b= double.Parse(Console.ReadLine());
        double c= double.Parse(Console.ReadLine());
        double res1 = a+b*c;       
        double res2 = a*b+c;       
        double res3 = c+a/b;      
        double res4 = a%b+c;       
        Console.WriteLine("The results of Int Operations are: " +res1 + ", " + res2 + ", " + res3 + ", " + res4);
    }
}
