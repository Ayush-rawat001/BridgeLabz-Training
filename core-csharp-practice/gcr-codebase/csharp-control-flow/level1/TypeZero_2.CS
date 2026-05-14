using System;

class TypeZero_2{
    static void Main(){
        int sum = 0;
        while (true){
            int num= Convert.ToInt32(Console.ReadLine());
            if (num <= 0){
                break;
            }
             sum = sum + num;
        }
        Console.WriteLine("The total value is " + sum);
    }
}
