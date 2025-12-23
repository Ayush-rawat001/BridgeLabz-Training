using System;

class NumberLength{
    static void Main(){
        int num= Convert.ToInt32(Console.ReadLine());
        int temp=num;
        int count=0;
        while(temp>0){
            count++;
            temp=temp/10;
        }

        Console.WriteLine("Length of "+num+" is "+count);
    }
}
