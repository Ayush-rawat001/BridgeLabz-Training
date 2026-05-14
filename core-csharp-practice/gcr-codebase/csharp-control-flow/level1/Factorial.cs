using System;
class Factorial{
    static void Main(){
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0){
            int fac = 1;
            int i = 1;

            while (i <= num)
            {
                fac = fac * i;
                i++;
            }

            Console.WriteLine("The factorial of " + num + " is " + fac);
        }
        else
        {
            Console.WriteLine("Please enter a positive integer");
        }
    }
}
