using System;
class LeapYear{
    static void Main(){
        int year = Convert.ToInt32(Console.ReadLine());
        // multiple if-else
        if (year < 1582){
            Console.WriteLine("Year is not valid (Gregorian calendar starts from 1582)");
        }
        else{
            if (year % 400 == 0){
                Console.WriteLine("Year is a Leap Year");
            }
            else if (year % 100 == 0){
                Console.WriteLine("Year is not a Leap Year");
            }
            else if (year % 4 == 0){
                Console.WriteLine("Year is a Leap Year");
            }
            else{
                Console.WriteLine("Year is not a Leap Year");
            }
        }

    