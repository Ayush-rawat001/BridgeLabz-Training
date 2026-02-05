using System;

class DivisionHandler
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double result = number1 / number2;
            Console.WriteLine($"Result of division: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values only.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Program execution completed.");
        }
    }
}
