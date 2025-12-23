using System;

class   HarshadNumber{
    static void Main(){
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int originalNum = num;
        while (originalNum != 0){
            int digit = originalNum % 10;   
            sum += digit;                      
            originalNum = originalNum / 10; 
        }
        if (num % sum == 0){
            Console.WriteLine(num + " is a Harshad number.");
        }
        else{
            Console.WriteLine(num + " is not a Harshad number.");
        }
    }
}
