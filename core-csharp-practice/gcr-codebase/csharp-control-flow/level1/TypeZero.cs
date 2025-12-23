using System;
class TypeZero{
    static void Main(){
       int sum=0;
        int num=Convert.ToInt32(Console.ReadLine());
        while (num != 0){
            sum = sum + num;
            num = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("The total value is " + sum);
    }
}