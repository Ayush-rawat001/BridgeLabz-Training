using System;

class ArrayNumberCheck{
    static void Main(){
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++){
            arr[i] = int.Parse(Console.ReadLine());

            if (IsPositive(arr[i])){
                Console.WriteLine(arr[i] % 2 == 0 ? "Positive Even" : "Positive Odd");
            }
            else{
                Console.WriteLine("Negative");
            }
        }

        int cmp = Compare(arr[0], arr[4]);
         if (cmp == 0) Console.WriteLine("Equal");
        else if (cmp == 1) Console.WriteLine("Greater");
        else Console.WriteLine("Less");
    }

    static bool IsPositive(int num){
        if (num < 0) return false;
        return true;
    }

    static bool IsEven(int num){
        return num % 2 == 0;
    }

    static int Compare(int n1, int n2){
        if (n1 > n2) return 1;
        if (n1 == n2) return 0;
        return -1;
    }
}
