using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"d:\BridgeLabz-Training\io-programming-csharp-practice\gcr-codebase\csharp-datahandling\students.csv";

        StreamReader sr = new StreamReader(path);

        string line;
         sr.ReadLine();

        while ((line = sr.ReadLine()) != null)
        {
            string[] data = line.Split(',');

            Console.WriteLine("ID    : " + data[0]);
            Console.WriteLine("Name  : " + data[1]);
            Console.WriteLine("Age   : " + data[2]);
            Console.WriteLine("Marks : " + data[3]+"\n");
            
        }

        sr.Close();
    }
}
