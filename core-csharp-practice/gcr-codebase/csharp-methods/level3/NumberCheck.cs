using System;

class NumberChecker{
    static void Main() {
        int number = int.Parse(Console.ReadLine());
int digitCount = CountDigits(number);
        int[] digits = GetDigits(number);
        Console.WriteLine(digitCount);                  
        Console.WriteLine(string.Join(", ", digits));  
        Console.WriteLine(IsDuckNumber(digits));        
        Console.WriteLine(IsArmstrongNumber(digits));   
        int[] largest = FindLargestAndSecondLargest(digits);
        Console.WriteLine(largest[0] + " " + largest[1]);   
        int[] smallest = FindSmallestAndSecondSmallest(digits);
        Console.WriteLine(smallest[0] + " " + smallest[1]); 
    }

    public static int CountDigits(int number) {
        int count = 0;
        int n = number;
        if (n == 0) return 1;

        while (n != 0) {
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

    public static bool IsDuckNumber(int[] digits){
        foreach (int d in digits){
            if (d != 0) return true;
        }
        return false;
    }

    public static bool IsArmstrongNumber(int[] digits){
        int n = digits.Length;
        int sum = 0;

        foreach (int d in digits){
            sum += (int)Math.Pow(d, n);
        }

        int number = 0;
        foreach (int d in digits){
            number = number * 10 + d;
        }

        return sum == number;
    }

    public static int[] FindLargestAndSecondLargest(int[] digits){
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        foreach (int d in digits){
            if (d > largest){
                secondLargest = largest;
                largest = d;
            }
            else if (d > secondLargest && d != largest){
                secondLargest = d;
            }
        }

        return new int[] { largest, secondLargest };
    }

    public static int[] FindSmallestAndSecondSmallest(int[] digits){
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        foreach (int d in digits){
            if (d < smallest) {
                secondSmallest = smallest;
                smallest = d;
            }
            else if (d < secondSmallest && d != smallest){
                secondSmallest = d;
            }
        }

        return new int[] { smallest, secondSmallest };
    }
}
