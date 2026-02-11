using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "employees.csv";

        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);

            int recordCount = lines.Length ; 

            Console.WriteLine("Total Records: " + recordCount);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
