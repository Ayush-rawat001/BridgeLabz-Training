using System;
class TextChars {
    static void Main() {
        string s = Console.ReadLine();
        string r = "";
        for (int i = 0; i < s.Length; i++) {
            r += s[i] + " ";
        }
        Console.WriteLine(r);
        Console.WriteLine(string.Join(" ", s.ToCharArray()));//built-in fn
    }
}
