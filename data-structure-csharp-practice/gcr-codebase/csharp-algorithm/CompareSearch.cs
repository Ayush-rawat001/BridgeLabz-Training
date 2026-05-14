
using System;
using System.Diagnostics;
using System.Linq;

class CompareSearch
{
    public static void Main(string[]args)
    {
        int size = 1000000;
        int[] data = Enumerable.Range(0, size).ToArray(); // dataset
        int target = 999999; // Target 

        // Linear Search 
        Stopwatch sw = new Stopwatch();
        sw.Start(); //creating and starting stopwatch object
        int linearResult = LinearSearch(data, target);
        sw.Stop(); //stop the stop watch 
        Console.WriteLine($"Linear Search:  index : {linearResult}, Time: {sw.Elapsed.TotalMilliseconds}ms");

        // Binary Search Execution
        sw.Restart();//restart the watch
        int binaryResult = BinarySearch(data, target);
        sw.Stop();//stop
        Console.WriteLine($"Binary Search: index : {binaryResult}, Time: {sw.Elapsed.TotalMilliseconds}ms");
    }

    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target) return i;
        }
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;  //find mid 
            if (arr[mid] == target) return mid; // if mid == target return mid
            if (arr[mid] < target) low = mid + 1;
            else high = mid - 1;
        }
        return -1;
    }
}