using System;

class P3 {
    static void Main() {
        DateTime n = DateTime.Now;
        Console.WriteLine(n.ToString("dd/MM/yyyy"));
        Console.WriteLine(n.ToString("yyyy-MM-dd"));
        Console.WriteLine(n.ToString("ddd, MMM dd, yyyy"));
    }
}
