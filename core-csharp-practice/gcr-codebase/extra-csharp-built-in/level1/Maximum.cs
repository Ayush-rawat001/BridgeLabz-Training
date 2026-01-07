using System;

class Game2 {
    static int[] Input() {
        int[] n = new int[3];
        for (int i = 0; i < 3; i++)
            n[i] = int.Parse(Console.ReadLine());
        return n;
    }

    static int Max(int[] n) => Math.Max(n[0], Math.Max(n[1], n[2]));

    static void Main() {
        Console.WriteLine("Enter 3 numbers:");
        Console.WriteLine("Max: " + Max(Input()));
    }
}
