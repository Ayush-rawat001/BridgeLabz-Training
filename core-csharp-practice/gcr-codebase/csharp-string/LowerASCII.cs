using System;
class LowerASCII {
    static void Main() {
        string str = Console.ReadLine();
        string res = "";
        for (int i = 0; i < str.Length; i++) {
            char c = str[i];
            if (c >= 'A' && c <= 'Z') c = (char)(c + 32);
            res += c;
        }
        Console.WriteLine(res);
        Console.WriteLine(str.ToLower());
    }
}
