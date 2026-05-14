using System;
class SumCheck{
    static void Main(){
        int n = int.Parse(Console.ReadLine());

        if (n < 1){
            Console.WriteLine("Invalid");
            return;
        }

        int recResult = RecursiveSum(n);
        int formulaResult = FormulaSum(n);

        Console.WriteLine(recResult);
        Console.WriteLine(formulaResult);

        Console.WriteLine(recResult == formulaResult);
    }

    static int RecursiveSum(int num){
        if (num == 1) return 1;
        return num + RecursiveSum(num - 1);
    }

    static int FormulaSum(int num){
        return num * (num + 1) / 2;
    }
}
