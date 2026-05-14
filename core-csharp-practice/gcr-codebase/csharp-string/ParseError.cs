using System;
class ParseError {
    static void Main() {
        string str = Console.ReadLine();
        try {
    int n = int.Parse(str);
        } catch (FormatException) {
            Console.WriteLine("FormatException");
        }
    }
}
