using System;

class Game3 {
    static bool Prime(int n) {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }

    static void Main() {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Prime(n).ToString().ToUpper());
    }
}
