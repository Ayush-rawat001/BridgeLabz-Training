using System;

class MathUtils
{
    long Factorial(int n)
    {
        if (n < 0) return -1;
        if (n == 0 || n == 1) return 1;
        long res = 1;
        for (int i = 2; i <= n; i++) res *= i;
        return res;
    }

    bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }

    int Gcd(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        if (a == 0) return b;
        if (b == 0) return a;
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    long Fibonacci(int n)
    {
        if (n < 0) return -1;
        if (n == 0) return 0;
        if (n == 1) return 1;
        long a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            long c = a + b;
            a = b;
            b = c;
        }
        return b;
    }

    static void Main()
    {
        MathUtils math = new MathUtils(); // instance 
        while (true)
        {
            Console.WriteLine("\n--- Math Utility Menu ---");
            Console.WriteLine("1. Factorial");
            Console.WriteLine("2. Prime Check");
            Console.WriteLine("3. GCD of Two Numbers");
            Console.WriteLine("4. Nth Fibonacci Number");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Enter number: ");
                    int f = Convert.ToInt32(Console.ReadLine());
                    long fr = math.Factorial(f);
                    Console.WriteLine(fr == -1 ? "Invalid input (negative)" : "Factorial = " + fr);
                    break;

                case 2:
                    Console.Write("Enter number: ");
                    int p = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(math.IsPrime(p) ? "Prime Number" : "Not Prime");
                    break;

                case 3:
                    Console.Write("Enter first number: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("GCD = " + math.Gcd(a, b));
                    break;

                case 4:
                    Console.Write("Enter n: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    long fib = math.Fibonacci(n);
                    Console.WriteLine(fib == -1 ? "Invalid input (negative)" : "Fibonacci = " + fib);
                    break;

                case 5:
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid option! Try again.");
                    break;
            }
        }
    }
}
