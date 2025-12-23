using System;

class Abundant{
    static void Main(){
    int num = Convert.ToInt32(Console.ReadLine());
     int sum = 0;
     for (int i = 1; i < num; i++){
            if (num % i == 0) {
                sum += i; 
            }
        }
        if (sum > num){
            Console.WriteLine(num + " is an Abundant Number.");
        }
        else{
            Console.WriteLine(num + " is not an Abundant Number.");
        }
    }
}
