using System;

class P4 {
    static DateTime ReadDate() {
        return DateTime.Parse(Console.ReadLine().Trim());
    }

    static void Main() {
        Console.Write("Enter first date: ");
        DateTime a = ReadDate();

        Console.Write("Enter second date: ");
        DateTime b = ReadDate();

        int cmp = a.CompareTo(b);

        string result = (cmp < 0) ? "before" :
                        (cmp > 0) ? "after" : "same";

        Console.WriteLine(result.ToUpper());
    }
}
