using System;

class NumFactorData{
    static void Main(){
        int n = Convert.ToInt32(Console.ReadLine());
        int[] f = CollectFactors(n);

        for (int i = 0; i < f.Length; i++)
            Console.Write(f[i] + " ");

        Console.WriteLine(AddFactors(f));
        Console.WriteLine(AddFactorPowers(f));
        Console.WriteLine(MulFactors(f));
    }

    static int[] CollectFactors(int num){
        int c = 0;
        for (int i = 1; i <= num; i++)
            if (num % i == 0) c++;

        int[] arr = new int[c];
        int k = 0;
        for (int i = 1; i <= num; i++)
            if (num % i == 0) arr[k++] = i;

        return arr;
    }

    static int AddFactors(int[] arr){
        int s = 0;
        for (int i = 0; i < arr.Length; i++)
            s += arr[i];
        return s;
    }

    static double AddFactorPowers(int[] arr){
        double s = 0;
        for (int i = 0; i < arr.Length; i++)
            s += Math.Pow(arr[i], 2);
        return s;
    }

    static long MulFactors(int[] arr){
        long p = 1;
        for (int i = 0; i < arr.Length; i++)
            p *= arr[i];
        return p;
    }
}
