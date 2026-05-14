using System;

class Calendar{
    static void Main(){
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        string monthName = GetMonthName(month);
        int daysInMonth = GetDaysInMonth(month, year);
        int firstDay = GetFirstDayOfMonth(month, year);

        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        
        for (int i = 0; i < firstDay; i++){
            Console.Write("    ");
        }

        
        for (int day = 1; day <= daysInMonth; day++) {
            Console.Write(day.ToString().PadLeft(3) + " ");
            if ((day + firstDay) % 7 == 0){
                Console.WriteLine();
            }
        }
    }

    //  Get month name
    public static string GetMonthName(int month){
        string[] months = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        return months[month - 1];
    }

    // Get number of days in month
    public static int GetDaysInMonth(int month, int year){
        int[] days = { 31, 28, 31, 30, 31, 30, 
                       31, 31, 30, 31, 30, 31 };
        if (month == 2 && IsLeapYear(year))
            return 29;
        else
            return days[month - 1];
    }

    //  Check leap year
    public static bool IsLeapYear(int year){
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    // c. Get first day of the month
    public static int GetFirstDayOfMonth(int month, int year) {
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + (31 * m0) / 12) % 7;
        return d0;
    }
}
