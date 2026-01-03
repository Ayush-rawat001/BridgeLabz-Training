using System;
class SubstringError {
    static void Main() {
        string str = Console.ReadLine();
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        try 
        {
            Console.WriteLine(str.Substring(x, y));
        } catch (ArgumentOutOfRangeException) {
            Console.WriteLine("ArgumentOutOfRangeException");
        }
    }
}
