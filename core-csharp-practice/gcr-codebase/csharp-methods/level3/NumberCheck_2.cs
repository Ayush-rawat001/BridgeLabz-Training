using System;

class NumberChecker_2{
    static void Main(){
        int number = int.Parse(Console.ReadLine());

        int digitCount = CountDigits(number);
        int[] digits = GetDigits(number);

        Console.WriteLine(digitCount);                  
        Console.WriteLine(string.Join(", ", digits));  

        int[] reversed = ReverseDigits(digits);
        Console.WriteLine(string.Join(", ", reversed)); 

        bool arraysEqual = AreArraysEqual(digits, reversed);
        Console.WriteLine(arraysEqual);                 
        bool isPalindrome = IsPalindrome(digits);
        Console.WriteLine(isPalindrome);                

        bool isDuck = IsDuckNumber(digits);
        Console.WriteLine(isDuck);                     
    }

    
    public static int CountDigits(int number){
        if (number == 0) return 1;
        int count = 0;
        int n = number;
        while (n != 0){
            count++;
            n /= 10;
        }
        return count;
    }

    
    public static int[] GetDigits(int number){
        int len = CountDigits(number);
        int[] digits = new int[len];
        int n = number;
        for (int i = len - 1; i >= 0; i--){
            digits[i] = n % 10;
            n /= 10;
        }
        return digits;
    }

   
    public static int[] ReverseDigits(int[] digits){
        int len = digits.Length;
        int[] reversed = new int[len];
        for (int i = 0; i < len; i++){
            reversed[i] = digits[len - 1 - i];
        }
        return reversed;
    }

    
    public static bool AreArraysEqual(int[] arr1, int[] arr2) {
        if (arr1.Length != arr2.Length) return false;
        for (int i = 0; i < arr1.Length; i++){
            if (arr1[i] != arr2[i]) return false;
        }
        return true;
    }

   
    public static bool IsPalindrome(int[] digits){
        int len = digits.Length;
        for (int i = 0; i < len / 2; i++){
            if (digits[i] != digits[len - 1 - i])
                return false;
        }
        return true;
    }

   
    public static bool IsDuckNumber(int[] digits) {
        foreach (int d in digits){
            if (d != 0) return true;
        }
        return false;
    }
}
