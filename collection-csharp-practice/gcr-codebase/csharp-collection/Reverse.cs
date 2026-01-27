using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> items = new List<string>
        {
            "apple", "banana", "apple", "orange"
        };

        Dictionary<string, int> frequency =
            new Dictionary<string, int>();

        foreach (string item in items)
        {
            if (frequency.ContainsKey(item))
            {
                frequency[item]++;
            }
            else
            {
                frequency[item] = 1;
            }
        }

        Console.WriteLine("Element Frequency:");

        foreach (var pair in frequency)
        {
            Console.WriteLine(pair.Key + " : " + pair.Value);
        }
    }
}
