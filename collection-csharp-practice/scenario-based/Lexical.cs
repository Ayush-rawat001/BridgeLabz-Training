using System;
using System.Collections.Generic;

class lexical
{
    static void Main()
    {
        Console.WriteLine("Enter first word:");
        string a = Console.ReadLine();

        if (a.Split(" ").Length > 1)
        {
            Console.WriteLine("Invalid string");
            return;
        }

        Console.WriteLine("Enter second word:");
        string b = Console.ReadLine();

        if (b.Split(" ").Length > 1)
        {
            Console.WriteLine("Invalid string");
            return;
        }

        bool isReversed = IsReversed(a, b);

        if (isReversed)
        {
            a = b.ToLower();
            string temp = "";

            for (int i = 0; i < a.Length; i++)
            {
                if (IsVowel(a[i]))
                    temp += "@";
                else
                    temp += a[i];
            }

            Console.WriteLine(temp);
        }
        else
        {
            a = (a + b).ToUpper();

            int vowel = 0;
            int consonant = 0;

            foreach (char c in a)
            {
                if (IsVowel(c))
                    vowel++;
                else
                    consonant++;
            }

            if (vowel == consonant)
            {
                Console.WriteLine("Vowels and consonants are equal");
                return;
            }

            HashSet<char> printed = new HashSet<char>();

            if (vowel > consonant)
            {
                Console.WriteLine("Unique vowels:");
                foreach (char c in a)
                {
                    if (IsVowel(c) && !printed.Contains(c))
                    {
                        Console.Write(c + " ");
                        printed.Add(c);
                    }
                }
            }
            else
            {
                Console.WriteLine("Unique consonants:");
                foreach (char c in a)
                {
                    if (!IsVowel(c) && !printed.Contains(c))
                    {
                        Console.Write(c + " ");
                        printed.Add(c);
                    }
                }
            }
        }
    }

    static bool IsReversed(string a, string b)
    {
        if (a.Length != b.Length) return false;

        int i = 0, j = b.Length - 1;

        while (i <= j)
        {
            if (a[i] != b[j])
                return false;
            i++;
            j--;
        }
        return true;
    }

    static bool IsVowel(char c)
    {
        return c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' || c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}
