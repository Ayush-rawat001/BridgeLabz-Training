using System;
class Table{
    static void Main(){
        int number = Convert.ToInt32(Console.ReadLine());
        int[] table = new int[10];
        for (int i = 0; i < 10; i++){
            table[i] = number * (i+1);
        }
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " * " +i+" = "+ table[i - 1]);
        }
    }
}
