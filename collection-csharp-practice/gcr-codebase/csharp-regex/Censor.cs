using System;
using System.Text.RegularExpressions;

class CensorBadWords
{
    static void Main()
    {
        string input = "This is a damn bad example with some stupid words.";
        
        string pattern = @"\b(damn|stupid)\b";

        string output = Regex.Replace(input, pattern, "****");

        Console.WriteLine(output);
    }
}
