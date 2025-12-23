using System;
class Factor{
    static void Main(){
    int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < number; i++){
            if (number % i == 0) {
                Console.Write(i + " "); 
            }
        }
        
    }
}
