using System;

class Armstrong{
    static void Main(){
        int num= Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int originalNum= num;
        int temp=originalNum;
        int length=0;
        while(temp>0){
            length++;
            temp=temp/10;
        }

        while (originalNum != 0){
            int digit = originalNum % 10;      
            sum +=(int)Math.Pow(digit,length);         
            originalNum = originalNum / 10; 
        }
         if (sum == num){
            Console.WriteLine( " it is an Armstrong number.");
        }
        else{
            Console.WriteLine("it  is not an Armstrong number.");
        }
    }
}
