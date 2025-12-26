using System;

class NumberCheck{
    static void Main(){
        int num = int.Parse(Console.ReadLine());
        int result = CheckNumber(num);
        Console.WriteLine(result);
    }

    static int CheckNumber(int n){
        if (n > 0) return 1;
        else if (n < 0) return -1;
        else return 0;
    }
}
