using System;

class SmallestLargest{
    static void Main(){
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int[] result = FindSmallestAndLargest(num1, num2, num3);
        Console.WriteLine("Smallest: " + result[0]);
        Console.WriteLine("Largest: " + result[1]);
    }

    public static int[] FindSmallestAndLargest(int number1, int number2, int number3){
        int smallest = number1;
        int largest = number1;
        if (number2 < smallest) smallest = number2;
        if (number3 < smallest) smallest = number3;
        if (number2 > largest) largest = number2;
        if (number3 > largest) largest = number3;

        return new int[] { smallest, largest };
    }
}
