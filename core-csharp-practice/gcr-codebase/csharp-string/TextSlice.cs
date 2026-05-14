using System;
class TextSlice {
    static void Main() {
        string s = Console.ReadLine();
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        string sub = "";
        for (int i = x; i <= y; i++) {
            sub += s[i];
        }
        Console.WriteLine(sub);
         Console.WriteLine(s.Substring(x, y - x + 1));//built-in fn
    }
}
