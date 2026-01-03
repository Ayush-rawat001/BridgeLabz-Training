using System;

class SubstringCount
 {
    static void Main() 
    {
        Console.WriteLine("Enter string:");
        string str = Console.ReadLine();
        Console.WriteLine("Enter substring ");
        string sub = Console.ReadLine();
        int count = 0;

        for (int i = 0; i <= str.Length - sub.Length; i++) {
            string temp = "";
            for (int j = 0; j < sub.Length; j++) {
                temp += str[i + j];
            }
            if (temp == sub) count++;
        }

        Console.WriteLine("Substring occurs: " + count + " times");
    }
}
