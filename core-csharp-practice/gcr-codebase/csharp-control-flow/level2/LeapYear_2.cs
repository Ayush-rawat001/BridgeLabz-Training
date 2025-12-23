using System;
class LeapYear_2{
    static void Main(){
       
        if (year >= 1582 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))){
            Console.WriteLine("Year is a Leap Year");
        }
        else if (year >= 1582){
            Console.WriteLine("Year is not a Leap Year");
        }
    }
}
