using System;

class NumberChecker_4{
    static void Main(){
        int number = int.Parse(Console.ReadLine());

        int[] factors = GetFactors(number);
        Console.WriteLine(string.Join(", ", factors));

        Console.WriteLine(GreatestFactor(factors));
        Console.WriteLine(SumOfFactors(factors));
        Console.WriteLine(ProductOfFactors(factors));
        Console.WriteLine(ProductOfCubes(factors));

        Console.WriteLine(IsPerfect(number, factors));
        Console.WriteLine(IsAbundant(number, factors));
        Console.WriteLine(IsDeficient(number, factors));
        Console.WriteLine(IsStrong(number));
    }

    
    public static int[] GetFactors(int number){
        int count = 0;
        for (int i = 1; i <= number; i++) {
            if (number % i == 0) count++;
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++){
            if (number % i == 0) factors[index++] = i;
        }
        return factors;
    }

    
    public static int GreatestFactor(int[] factors) {
        int max = factors[0];
        foreach (int f in factors){
            if (f > max) max = f;
        }
        return max;
    }

    
    public static int SumOfFactors(int[] factors){
        int sum = 0;
        foreach (int f in factors) sum += f;
        return sum;
    }

    
    public static long ProductOfFactors(int[] factors) {
        long prod = 1;
        foreach (int f in factors) prod *= f;
        return prod;
    }

    
    public static double ProductOfCubes(int[] factors){
        double prod = 1;
        foreach (int f in factors) {
            prod *= Math.Pow(f, 3);
        }
        return prod;
    }

    
    public static bool IsPerfect(int number, int[] factors){
        int sumProper = 0;
        foreach (int f in factors){
            if (f != number) sumProper += f;
        }
        return sumProper == number;
    }

    
    public static bool IsAbundant(int number, int[] factors){
        int sumProper = 0;
        foreach (int f in factors){
            if (f != number) sumProper += f;
        }
        return sumProper > number;
    }

    
    public static bool IsDeficient(int number, int[] factors){
        int sumProper = 0;
        foreach (int f in factors) {
            if (f != number) sumProper += f;
        }
        return sumProper < number;
    }

   
    public static bool IsStrong(int number){
        int sum = 0;
        int n = number;
        while (n != 0) {
            int digit = n % 10;
            sum += Factorial(digit);
            n /= 10;
        }
        return sum == number;
    }

    public static int Factorial(int n){
        int fact = 1;
        for (int i = 2; i <= n; i++) fact *= i;
        return fact;
    }
}
