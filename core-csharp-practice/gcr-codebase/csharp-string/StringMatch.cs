using System;
class StringMatch {
    static void Main() {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        bool same = true;
        if (a == null || b == null || a.Length != b.Length) same = false;
        else {
            for (int i = 0; i < a.Length; i++) {
                if (a[i] != b[i]) 
                { 
                    same = false; 
                    break; 
                }
            }
        }
        Console.WriteLine(same);
        Console.WriteLine(string.Equals(a, b));//built-in fn
    }
}
