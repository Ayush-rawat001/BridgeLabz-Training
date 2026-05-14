using System;

class ReverseString {
    static void Main() {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();
        string rev = "";
 for (int i = str.Length - 1; i >= 0; i--) 
 {
            rev += str[i];
        }

        Console.WriteLine(rev);
    }
}
