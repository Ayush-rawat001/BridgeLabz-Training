using System;

class SpringS{
    static void Main(){
        int month = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());

        if (IsSpring(month, day))
            Console.WriteLine("Its a Spring Season");
        else
            Console.WriteLine("Not a Spring Season");
    }

    static bool IsSpring(int month, int day){
    if (month < 3 || month > 6) return false;
         if (month == 3 && day < 20) return false;
        if (month == 6 && day > 20) return false;
        return true;
    }
}
