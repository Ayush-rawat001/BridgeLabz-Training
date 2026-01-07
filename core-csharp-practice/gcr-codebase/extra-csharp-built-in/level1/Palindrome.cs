using System;

class Game5 {
    static bool Pal(string s) {
        string rev = new string(s.Reverse().ToArray());
        return s.Equals(rev, StringComparison.OrdinalIgnoreCase);
    }

    static void Main() {
        string s = Console.ReadLine().Trim();
        Console.WriteLine(Pal(s).ToString().ToLower());
    }
}
