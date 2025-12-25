using System;

class Vote{
    static void Main(){
        int[] ages= new int[10];
        for (int i = 0; i < ages.Length; i++){
        ages[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        for (int i = 0; i < ages.Length; i++){
            int age = ages[i];
            if (age < 0){
                Console.WriteLine("Invalid age");
            }
            else if (age >= 18){
                Console.WriteLine("The student with the age "+age+" can vote.");
            }
            else
            {
              Console.WriteLine("The student with the age "+age+" can not vote.");            }
        }
    }
}
