using System;

class Game4 {
    static string Fib(int t) {
        int a = 0, b = 1;
        string s = "";
        for (int i = 0; i < t; i++) {
            s += a.ToString() + " ";
            int c = a + b;
            a = b;
            b = c;
        }
        return s.Trim();
    }

    static void Main() {
        int t = int.Parse(Console.ReadLine());
        Console.WriteLine(Fib(t));
    }
}
