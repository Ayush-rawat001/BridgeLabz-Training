using System;

class OddEven{
    static void Main(){
        int number = Convert.ToInt32(Console.ReadLine());
         if (number > 0){
            for (int i = 1; i <= number; i++){
                if (i % 2 == 0) {
                    Console.WriteLine(i + " is even");
                }
                else{
                    Console.WriteLine(i + " is odd");
                }
            }
           } else{
            Console.WriteLine("Please enter a natural number");
        }
       
    }
}
