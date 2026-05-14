using System;
class WordReplace {
    static void Main() {
        Console.WriteLine("Enter sentence:");
        string s = Console.ReadLine();
        Console.WriteLine("Enter word to replace:");
        string old = Console.ReadLine();
        Console.WriteLine("Enter new word:");
        string neu = Console.ReadLine();
        string res = "";

        for (int i = 0; i <= s.Length - old.Length; i++) {
            string temp = "";
            for (int j = 0; j < old.Length; j++) {
                temp += s[i + j];
            }
            if (temp == old) {
                res += neu;
                i += old.Length - 1;
            } else {
                res += s[i];
            }
        }

        Console.WriteLine( res);
    }
}
