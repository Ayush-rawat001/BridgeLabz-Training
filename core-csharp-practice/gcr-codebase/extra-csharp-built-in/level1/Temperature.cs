using System;

class Game8 {
    static string FtoC(double f) => ((f - 32) * 5 / 9).ToString("F2");
    static string CtoF(double c) => (c * 9 / 5 + 32).ToString("F2");

    static void Main() {
        double t = double.Parse(Console.ReadLine());
        string c = Console.ReadLine().ToLower();
        Console.WriteLine(c.Equals("c") ? FtoC(t) : CtoF(t));
    }
}
