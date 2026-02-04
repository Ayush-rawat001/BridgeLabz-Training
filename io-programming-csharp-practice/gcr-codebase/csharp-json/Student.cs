using System;
using System.Text.Json;

class Program
{
    static void Main()
    {
        var student = new
        {
            name = "Ayush Rawat",
            age = 21,
            subjects = new string[] { "Maths", "Computer Science", "Data Structures" }
        };

        string json = JsonSerializer.Serialize(student, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        Console.WriteLine(json);
    }
}
