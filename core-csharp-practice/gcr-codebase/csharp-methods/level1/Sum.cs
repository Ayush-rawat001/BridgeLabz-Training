using System;

class Sum{
    static void Main(){
        int n = int.Parse(Console.ReadLine());
        int sum = FindSum(n);
        Console.WriteLine(sum);
    }

    static int FindSum(int n){
        int sum = 0;
        for (int i = 1; i <= n; i++){
            sum += i;
        }
        return sum;
    }
}
