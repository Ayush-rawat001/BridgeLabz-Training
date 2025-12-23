using System;
class Bonus{
    static void Main(){
        double salary = Convert.ToDouble(Console.ReadLine());
        int years= Convert.ToInt32(Console.ReadLine());
        double bonus = 0.0;
        if (years > 5){
            bonus = salary * 0.05;
            Console.WriteLine("The bonus amount is " + bonus);
        }
        else{
            Console.WriteLine("No bonus. Years of service is less than or equal to 5.");
        }
    }
}
