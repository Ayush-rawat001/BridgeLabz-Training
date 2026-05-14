using System;

class NumberChecker_3{
    static void Main() {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(number));
        Console.WriteLine(IsNeon(number));
        Console.WriteLine(IsSpy(number));
        Console.WriteLine(IsAutomorphic(number));
        Console.WriteLine(IsBuzz(number));
    }

    
    public static bool IsPrime(int number){
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++){
            if (number % i == 0) return false;
        }
        return true;
    }

   
    public static bool IsNeon(int number){
        int square = number * number;
        int sum = 0;
        while (square != 0){
            sum += square % 10;
            square /= 10;
        }
        return sum == number;
    }

    
    public static bool IsSpy(int number){
        int sum = 0, product = 1;
        int n = number;
        while (n != 0) {
            int digit = n % 10;
            sum += digit;
            product *= digit;
            n /= 10;
        }
        return sum == product;
    }

   
    public static bool IsAutomorphic(int number){
        int square = number * number;
        string numStr = number.ToString();
        string sqStr = square.ToString();
        return sqStr.EndsWith(numStr);
    }

   
    public static bool IsBuzz(int number){
        return number % 7 == 0 || number % 10 == 7;
    }
}
