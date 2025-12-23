using System;
class Factorial_2{
    static void Main(){
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0){
            int fac = 1;
            int i = 1;

            for(i=1;i<=num;i++){
                fac=fac*i;
            }

            Console.WriteLine("The factorial of " + num + " is " + fac);
        }
        else
        {
            Console.WriteLine("Please enter a positive integer");
        }
    }
}
