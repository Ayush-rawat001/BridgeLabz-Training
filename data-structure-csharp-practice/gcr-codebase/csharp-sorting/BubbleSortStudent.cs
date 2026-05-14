using System;

class BubbleSortStudentMarks
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] marks = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter marks of student {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nMarks Before Sorting:");
        PrintArray(marks);

        BubbleSort(marks);

        Console.WriteLine("\nMarks After Sorting (Ascending Order):");
        PrintArray(marks);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int mark in arr)
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();
    }
}
