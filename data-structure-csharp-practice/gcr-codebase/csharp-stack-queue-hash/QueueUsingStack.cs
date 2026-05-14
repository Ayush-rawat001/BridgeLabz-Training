using System;
using System.Collections.Generic;

class QueueUsingStacks
{
    static Stack<int> stackEnqueue = new Stack<int>();
    static Stack<int> stackDequeue = new Stack<int>();

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Queue Using Stacks ---");
            Console.WriteLine("1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. Display Queue");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter element to enqueue: ");
                    int value = int.Parse(Console.ReadLine());
                    Enqueue(value);
                    break;

                case 2:
                    Dequeue();
                    break;

                case 3:
                    Display();
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 4);
    }

    static void Enqueue(int value)
    {
        stackEnqueue.Push(value);
        Console.WriteLine(value + " enqueued successfully.");
    }

    static void Dequeue()
    {
        if (stackDequeue.Count == 0)
        {
            // Transfer elements from enqueue stack to dequeue stack
            while (stackEnqueue.Count > 0)
            {
                stackDequeue.Push(stackEnqueue.Pop());
            }
        }

        if (stackDequeue.Count == 0)
        {
            Console.WriteLine("Queue is empty. Cannot dequeue.");
            return;
        }

        int removed = stackDequeue.Pop();
        Console.WriteLine("Dequeued element: " + removed);
    }

    static void Display()
    {
        if (stackEnqueue.Count == 0 && stackDequeue.Count == 0)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        Console.Write("Queue elements: ");

        // Elements in dequeue stack (top to bottom)
        foreach (int item in stackDequeue)
        {
            Console.Write(item + " ");
        }

        // Elements in enqueue stack (bottom to top)
        int[] arr = stackEnqueue.ToArray();
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }
}
