using System;
class Largest{
    static void Main(){
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());
        if (num1 > num2 && num1 > num3){
            Console.WriteLine("Is the first number the largest? Yes");
        }
        else{
            Console.WriteLine("Is the first number the largest? No");
        }

        if (num2 > num1 && num2 > num3){
            Console.WriteLine("Is the second number the largest? Yes");
        }
        else{
            Console.WriteLine("Is the second number the largest? No");
        }

        if (num3 > num1 && num3 > num2){
            Console.WriteLine("Is the third number the largest? Yes");
        }
        else{
            Console.WriteLine("Is the third number the largest? No");
        }
    }
}
