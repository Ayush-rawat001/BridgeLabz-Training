
using System;

class PosNegZero{
    static void Main(){
        int[] arr = new int[5];
        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < arr.Length; i++){
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i=0;i<arr.Length;i++){
            int num = arr[i];
            if (num > 0){
                if (num % 2 == 0){
                     Console.WriteLine("Positive and Even."}
                   
                else{
                     Console.WriteLine( " Positive and Odd.");}
                   
            }
            else if (num < 0){
                Console.WriteLine("Negative");
            }
            else{
                Console.WriteLine("Zero");
            }
        }

        // Compare 
        int first = arr[0];
        int last = arr[arr.Length - 1];
        if (first == last){
            Console.WriteLine("First  and Last elements are Equal."); }
        else if (first > last){
            Console.WriteLine("First element  is Greater than last element.");
        }
        else {
            Console.WriteLine("First element  is Less than last element.");
        }
    }
}
