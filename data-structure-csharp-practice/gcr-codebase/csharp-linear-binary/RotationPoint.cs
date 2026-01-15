using System;

class RotationPoint
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter array elements (space separated):");
        string[] input = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(input[i]);
        }

        int index = FindRotationPoint(arr);

        Console.WriteLine($"Rotation Point Index: {index}");
        Console.WriteLine($"Smallest Element: {arr[index]}");
    }

    static int FindRotationPoint(int[] arr)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            // 🔑 Core logic (as you asked)
            if (arr[mid] >= arr[low])
                low = mid + 1;
            else
                high = mid;
        }

        return low; // index of smallest element
    }
}
