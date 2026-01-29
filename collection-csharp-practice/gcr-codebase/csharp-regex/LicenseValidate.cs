using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter license plate number: ");
        string plate = Console.ReadLine();

        string pattern = @"^[A-Z]{2}[0-9]{4}$";

        if (Regex.IsMatch(plate, pattern))
        {
            Console.WriteLine(" Valid License Plate Number");
        }
        else
        {
            Console.WriteLine(" Invalid License Plate Number");
        }
    }
}
