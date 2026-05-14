using System;

class Game6 {
    static int F(int n) => n <= 1 ? 1 : n * F(n - 1);
    static void Main() {
        Console.WriteLine(F(int.Parse(Console.ReadLine())).ToString());
    }
}
