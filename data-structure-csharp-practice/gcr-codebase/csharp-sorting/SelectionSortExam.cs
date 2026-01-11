using System;

class SelectionSortExamScores
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] scores = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter exam score of student {i + 1}: ");
            scores[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nScores Before Sorting:");
        PrintArray(scores);

        SelectionSort(scores);

        Console.WriteLine("\nScores After Sorting (Ascending Order):");
        PrintArray(scores);
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            // Find minimum element in unsorted part
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap with first unsorted element
            if (minIndex != i)
            {
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int score in arr)
        {
            Console.Write(score + " ");
        }
        Console.WriteLine();
    }
}
