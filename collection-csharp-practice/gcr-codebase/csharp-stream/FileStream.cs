using System;
using System.IO;

class SimpleFileCopy
{
    static void Main()
    {
        string source = "source.txt";
        string dest = "destination.txt";

        if (!File.Exists(source))
        {
            Console.WriteLine("Source file does not exist.");
            return;
        }

        try
        {
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(dest, FileMode.Create, FileAccess.Write))
            {
                fsRead.CopyTo(fsWrite); // Copy all content
            }

            Console.WriteLine("File copied successfully!");
        }
        catch (IOException ioEx)
        {
            Console.WriteLine("I/O error occurred: " + ioEx.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
