using System;

class Table_2{
    static void Main(){
    int num = Convert.ToInt32(Console.ReadLine());

        int[] res = new int[4]; 
        int j = 0;
        for (int i = 6; i <= 9; i++){
            res[j] = num * i;
            j++;
        }
        
        j = 0;
        for (int i = 6; i <= 9; i++){
            Console.WriteLine(num +" * "+i+" = "+ res[j]);
            j++;
        }
    }
}
