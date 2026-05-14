using System;
class AnagramCheck
{
    static void Main()
    {
        Console.WriteLine("first text:");
        string a = Console.ReadLine();
        Console.WriteLine("second text:");
        string b = Console.ReadLine();

        if (a.Length != b.Length)
        {
            Console.WriteLine("Not Anagrams");
            return;
        }

        a = a.ToLower();
        b = b.ToLower();
        bool flag = true;

        for (int i = 0; i < a.Length; i++)
        {
            int ca = 0, cb = 0;
            for (int j = 0; j < a.Length; j++)
            {
                if (a[i] == a[j]) ca++;
                if (a[i] == b[j]) cb++;
            }
            if (ca != cb) { flag = false; break; }
        }

        if (flag) Console.WriteLine("Anagrams");
        else Console.WriteLine("Not Anagrams");
    }
}
