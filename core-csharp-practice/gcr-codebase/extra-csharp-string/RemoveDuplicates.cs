using System;

class RemoveDuplicates 
{
    static void Main() 
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();
        string res = "";
         foreach (char ch in str) {
            if (!res.Contains(ch)) 
            {
                res += ch;
            }
        }

        Console.WriteLine( res);
    }
}
