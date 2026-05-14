using System;

class FirstNegativeSearch
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        bool isFound = false;

        for (int i = 0; i < n; i++)
        {
            if (numbers[i] < 0)
            {
                Console.WriteLine("First negative number is: " + numbers[i]);
                isFound = true;
                break;
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No negative number in the array");
        }
    }
}
