using System;

class BMI{
    static void Main(){
         double weight = Convert.ToDouble(Console.ReadLine());
         double height = Convert.ToDouble(Console.ReadLine());
         double heightInMeter = height / 100;
         double bmi = weight / (heightInMeter * heightMeter);
         Console.WriteLine("BMI = "+bmi);
         if (bmi <18.5){
            Console.WriteLine("Underweight");
        }
        else if (bmi < 25){
            Console.WriteLine("Normal");
        }
        else if (bmi < 40){
            Console.WriteLine("Overweight");
        }
        else{
            Console.WriteLine("Obese");
        }
    }
}
