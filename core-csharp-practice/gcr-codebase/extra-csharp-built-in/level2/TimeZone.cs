using System;

class P1 {
    static void Main() {
        DateTimeOffset now = DateTimeOffset.UtcNow;

        Console.WriteLine("GMT: " + now.ToString());

        Console.WriteLine("IST: " + TimeZoneInfo.ConvertTimeBySystemTimeZoneId(now, "India Standard Time").ToString());

        Console.WriteLine("PST: " + TimeZoneInfo.ConvertTimeBySystemTimeZoneId(now, "Pacific Standard Time").ToString());
    }
}
