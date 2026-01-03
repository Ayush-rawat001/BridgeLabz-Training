using System;

class LongestWord 
{
    static void Main() 
    {
        Console.WriteLine("Enter a sentence:");
        string str = Console.ReadLine();
        string temp = "";
        string result = "";

        for (int i = 0; i <= str.Length; i++) {
            if (i == str.Length || str[i] == ' ') {
                if (temp.Length > result.Length) {
                    result = temp;
                }
                temp = "";
            } else {
                temp += str[i];
            }
        }

        Console.WriteLine("result word: " + result);
    }
}
