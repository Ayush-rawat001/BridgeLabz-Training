using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>
        {
            3, 1, 2, 2, 3, 4
        };

        List<int> result = new List<int>();
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in numbers)
        {
            if (seen.Add(num))   // Add returns false if duplicate
            {
                result.Add(num);
            }
        }

        Console.WriteLine("Result:");

        foreach (int n in result)
            Console.Write(n + " ");
    }
}
