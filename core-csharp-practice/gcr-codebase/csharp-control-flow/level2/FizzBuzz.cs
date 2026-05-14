using System;

class FizzBuzz{
    static void Main(){
        int num  = Convert.ToInt32(Console.ReadLine());
       if (num  > 0){
            for (int j = 1; j <= num ; j++){
                if (j % 3 == 0 && j % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                }
                else if (j % 3 == 0){
                    Console.WriteLine("Fizz");
                }
                else if (j % 5 == 0){
                    Console.WriteLine("Buzz");
                }
                else{
                    Console.WriteLine(j);
                }
            }
        }
        else{
            Console.WriteLine("Please enter a positive integer");
        }
    }
}
