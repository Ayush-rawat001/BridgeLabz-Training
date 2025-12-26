using System;

class YearCheck{
    static void Main(){
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine(IsLeap(y));
    }

    static string IsLeap(int year){
        if (year < 1582)
            return "Invalid";

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            return "Leap";

        return "NotLeap";
    }
}
