using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>()
        {
            10, 20, 30, 40, 50
        };

        int rotateBy = 2;

        RotateList(numbers, rotateBy);

        Console.WriteLine("Rotated List:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }

    static void RotateList(List<int> list, int k)
    {
        int n = list.Count;

        // Handle rotation greater than list size
        k = k % n;

        List<int> temp = new List<int>();

        // Add elements from k to end
        for (int i = k; i < n; i++)
        {
            temp.Add(list[i]);
        }

        // Add first k elements
        for (int i = 0; i < k; i++)
        {
            temp.Add(list[i]);
        }

        // Copy back to original list
        for (int i = 0; i < n; i++)
        {
            list[i] = temp[i];
        }
    }
}
