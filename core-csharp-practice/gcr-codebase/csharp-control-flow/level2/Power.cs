using System;
class Power{
    static void Main(){
         int num = Convert.ToInt32(Console.ReadLine());
         int power = Convert.ToInt32(Console.ReadLine());
         int result = 1; 
         for (int i = 1; i <= power; i++){
            result = result * num;
        }
         Console.WriteLine(result);
    }
}
