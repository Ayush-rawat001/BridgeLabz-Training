using System;
class LexicoCompare{
    static void Main(){
        Console.WriteLine("Enter first text:");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter second text:");
        string str2 = Console.ReadLine();

        int len = str1.Length < str2.Length ? str1.Length : str2.Length;
        bool decided = false;

        for (int i = 0; i < len; i++) {
            if (str1[i] < str2[i]) {
                Console.WriteLine(str1 + " comes before " + str2);
                decided = true;
                break;
            } else if (str1[i] > str2[i]) {
                Console.WriteLine(str2 + " comes before " + str1);
                decided = true;
                break;
            }
        }

        if (!decided) {
            if (str1.Length < str2.Length)
                Console.WriteLine(str1 + " comes before " + str2);
            else if (str1.Length > str2.Length)
                Console.WriteLine(str2 + " comes before " + str1);
            else
                Console.WriteLine("Both are equal");
        }
    }
}
