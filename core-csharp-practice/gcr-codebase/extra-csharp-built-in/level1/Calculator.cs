using System;

class Game9 {
    static string Add(int a, int b) => (a + b).ToString();
    static string Sub(int a, int b) => (a - b).ToString();
    static string Mul(int a, int b) => (a * b).ToString();
    static string Div(int a, int b) => ((double)a / b).ToString("F2");

    static void Main() {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        string c = Console.ReadLine();

        Console.WriteLine(
            c.Equals("1") ? Add(a, b) :
            c.Equals("2") ? Sub(a, b) :
            c.Equals("3") ? Mul(a, b) :
            c.Equals("4") ? Div(a, b) : "err"
        );
    }
}
