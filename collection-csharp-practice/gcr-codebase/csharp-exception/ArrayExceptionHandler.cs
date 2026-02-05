using System;

class ArrayExceptionHandler
{
    static void Main()
    {
        try
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.Write("Enter index number: ");
            int index = Convert.ToInt32(Console.ReadLine());

            // Accessing array element
            int value = numbers[index];

            Console.WriteLine($"Value at index {index}: {value}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid integer index.");
        }
    }
}
