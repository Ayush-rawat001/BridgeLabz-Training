using System;
using System.Text.RegularExpressions;

class IPValidator
{
    static void Main()
    {
        Console.Write("Enter IP address: ");
        string ip = Console.ReadLine();

        string pattern = @"^((25[0-5]|2[0-4][0-9]|1?[0-9]{1,2})\.){3}" +@"(25[0-5]|2[0-4][0-9]|1?[0-9]{1,2})$";

        if (Regex.IsMatch(ip, pattern))
        {
            Console.WriteLine("Valid IPv4 address");
        }
        else
        {
            Console.WriteLine("Invalid IPv4 address");
        }
    }
}
