using System;

class P2 {
    static DateTime TakeDate() {
        string input = Console.ReadLine().Trim();
        return DateTime.Parse(input);
    }

    static void Main() {
        Console.Write("Enter a date: ");
        DateTime d = TakeDate();

        d = d.AddDays(7).AddMonths(1).AddYears(2);
        d = d.AddDays(-21); // subtract 3 weeks

        Console.WriteLine("Final Date: " + d.ToString());
    }
}
