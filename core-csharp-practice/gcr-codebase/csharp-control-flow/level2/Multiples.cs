using System;

class Multiple{
    static void Main(){
    int num = Convert.ToInt32(Console.ReadLine());
for (int i = 100; i >= 1; i--){
            if (i % num == 0) 
            {
                Console.Write(i + " "); 
            }
        }
       
    }
}
