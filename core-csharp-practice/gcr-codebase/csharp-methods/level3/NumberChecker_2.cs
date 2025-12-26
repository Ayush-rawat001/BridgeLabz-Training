using System;

class NumberChecker_2{
    static void Main(){
        int number = int.Parse(Console.ReadLine());

        int digitCount = CountDigits(number);
        int[] digits = GetDigits(number);

        Console.WriteLine(digitCount);                  
        Console.WriteLine(string.Join(", ", digits));   

        int sum = SumOfDigits(digits);

        int sumSquares = SumOfSquares(digits);
        Console.WriteLine(sumSquares);                  

        bool isHarshad = IsHarshadNumber(number, digits);
        Console.WriteLine(isHarshad);                   

        int[,] freq = DigitFrequency(digits);
        for (int i = 0; i < freq.GetLength(0); i++)
        {
            Console.WriteLine(freq[i,0] + " " + freq[i,1]); 
        }
    }

    
    public static int CountDigits(int number)
    {
        if (number == 0) return 1;
        int count = 0;
        int n = number;
        while (n != 0)
        {
            count++;
            n /= 10;
        }
        return count;
    }

    
    public static int[] GetDigits(int number)
    {
        int len = CountDigits(number);
        int[] digits = new int[len];
        int n = number;
        for (int i = len - 1; i >= 0; i--)
        {
            digits[i] = n % 10;
            n /= 10;
        }
        return digits;
    }

    
    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int d in digits) sum += d;
        return sum;
    }

   
    public static int SumOfSquares(int[] digits)
    {
        int sum = 0;
        foreach (int d in digits)
        {
            sum += (int)Math.Pow(d, 2);
        }
        return sum;
    }

   
    public static bool IsHarshadNumber(int number, int[] digits)
    {
        int sum = SumOfDigits(digits);
        if (sum == 0) return false;
        return number % sum == 0;
    }

  
    public static int[,] DigitFrequency(int[] digits)
    {
        int[,] freq = new int[10,2];
        for (int i = 0; i < 10; i++)
        {
            freq[i,0] = i;
            freq[i,1] = 0;
        }

        foreach (int d in digits)
        {
            freq[d,1]++;
        }
        return freq;
    }
}
