using System;
class StringIndexError {
    static void Main() {
        string str = Console.ReadLine();
        try {
            Console.WriteLine(str[100]);
        } catch (IndexOutOfRangeException) {
            Console.WriteLine("IndexOutOfRangeException");
        }
    }
}
