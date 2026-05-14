using System;
using System.Text;

class SentenceFormatter
{
    // format paragraph
    public string FixParagraph(string text)
    {
        text = text.Trim(); // trim
        StringBuilder finalText = new StringBuilder();
        bool capNext = true; // caps flag

        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if (capNext && char.IsLetter(c))
            {
                finalText.Append(char.ToUpper(c)); // caps
                capNext = false;
            }
            else if (c == '.' || c == '!' || c == '?')
            {
                finalText.Append(c); // punct
                finalText.Append(' '); // space
                capNext = true;
            }
            else if (c == ' ')
            {
                if (finalText.Length > 0 && finalText[finalText.Length - 1] != ' ')
                    finalText.Append(' '); // one space
            }
            else
            {
                finalText.Append(c); // char
            }
        }

        return finalText.ToString().Trim(); // return
    }

    // start
    public static void Main()
    {
        Console.WriteLine("Write paragraph:");
        string userInput = Console.ReadLine();

        SentenceFormatter app = new SentenceFormatter();
        string formattedOutput = app.FixParagraph(userInput);

        Console.WriteLine("\nDone:");
        Console.WriteLine(formattedOutput);
    }
}
