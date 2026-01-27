using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<string> list = new LinkedList<string>();

        list.AddLast("A");
        list.AddLast("B");
        list.AddLast("C");
        list.AddLast("D");
        list.AddLast("E");

        int n = 2;

        string result = FindNthFromEnd(list, n);

        Console.WriteLine("Nth element from end: " + result);
    }

    static string FindNthFromEnd(LinkedList<string> list, int n)
    {
        if (list == null || n <= 0)
            return null;

        LinkedListNode<string> first = list.First;
        LinkedListNode<string> second = list.First;

        // Move first pointer n steps ahead
        for (int i = 0; i < n; i++)
        {
            if (first == null)
                return null;

            first = first.Next;
        }

        // Move both until first reaches end
        while (first != null)
        {
            first = first.Next;
            second = second.Next;
        }

        return second.Value;
    }
}
