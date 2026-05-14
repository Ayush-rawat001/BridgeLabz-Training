using System;
class RemoveLetter {
    static void Main() {
        Console.WriteLine("Enter string:");
        string s = Console.ReadLine();
        Console.WriteLine("Enter character you want to remove:");
        char r = Console.ReadLine()[0];
        string res = "";

        for (int i = 0; i < s.Length; i++) {
            if (s[i] != r) res += s[i];
        }

        Console.WriteLine( res);
    }
}
