using System;

class Palindrome 
{
    static void Main() 
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();
        string rev = "";

        for (int i = str.Length - 1; i >= 0; i--)
         {
            rev += str[i];
        }

        if (str == rev)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not a Palindrome");
    }
}
