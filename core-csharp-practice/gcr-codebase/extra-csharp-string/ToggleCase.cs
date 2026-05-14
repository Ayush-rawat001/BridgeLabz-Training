using System;

class ToggleCase {
    static void Main() {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();
        string result = "";

        foreach (char ch in str) {
            if (ch >= 'A' && ch <= 'Z')
                result += (char)(ch + 32); // Upper to lower
            else if (ch >= 'a' && ch <= 'z')
                result += (char)(ch - 32); // Lower to upper
            else
                result += ch;
        }

        Console.WriteLine("Toggled string: " + result);
    }
}
