using System;

public class Vote{
    public static bool CanStudentVote(int age){
        if (age < 0) return false;
        if (age >= 18) return true;
        return false;
    }

    public static void Main(){
        int[] ages = new int[10];

        for (int i = 0; i < 10; i++){
            ages[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(CanStudentVote(ages[i]));
        }
    }
}
