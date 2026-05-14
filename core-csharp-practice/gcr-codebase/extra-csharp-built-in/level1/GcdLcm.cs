using System;

class Game7 {
    static int G(int a, int b) => b == 0 ? a : G(b, a % b);
    static int L(int a, int b) => (a * b) / G(a, b);

    static void Main() {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("gcd:" + G(a, b).ToString());
        Console.WriteLine("lcm:" + L(a, b).ToString());
    }
}
