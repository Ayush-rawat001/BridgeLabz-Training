using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "employees.csv";

        // CSV Header
        string[] lines =
        {
            "ID,Name,Department,Salary",
            "1,Ayush Rawat,IT,60000",
            "2,Riya Sharma,HR,45000",
            "3,Amit Verma,Finance,55000",
            "4,Neha Singh,Marketing,50000",
            "5,Rohan Gupta,Sales,48000"
        };

        // Write to file
        File.WriteAllLines(path, lines);

        Console.WriteLine("CSV file created successfully!");
    }
}
