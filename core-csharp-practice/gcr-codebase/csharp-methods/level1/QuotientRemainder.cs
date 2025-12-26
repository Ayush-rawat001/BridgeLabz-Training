using System;

class QuotientRemainder{
    static void Main(){
        int number = int.Parse(Console.ReadLine());
        int divisor = int.Parse(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(number, divisor);
        Console.WriteLine("Quotient: " + result[0]);
        Console.WriteLine("Remainder: " + result[1]);
    }

    public static int[] FindRemainderAndQuotient(int number, int divisor){
        int quotient = number / divisor;
        int remainder = number % divisor;
       return new int[] { quotient, remainder };
    }
}
