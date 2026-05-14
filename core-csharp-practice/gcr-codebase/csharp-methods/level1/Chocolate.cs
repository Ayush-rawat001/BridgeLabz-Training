using System;

class Chocolate{
    static void Main(){
        int numberOfChocolates = int.Parse(Console.ReadLine());
        int numberOfChildren = int.Parse(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);
        Console.WriteLine("Chocolates per child: " + result[0]);
        Console.WriteLine("Remaining chocolates: " + result[1]);
    }

    public static int[] FindRemainderAndQuotient(int number, int divisor){
        int quotient = number / divisor;
        int remainder = number % divisor;
        return new int[] { quotient, remainder };
    }
}
