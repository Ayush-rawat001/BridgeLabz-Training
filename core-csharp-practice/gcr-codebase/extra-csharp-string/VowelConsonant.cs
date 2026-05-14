using System;

class VowelConsonant {
    static void Main() {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();
        int vowels = 0, cons = 0;

        foreach (char ch in str.ToLower()) {
            if ((ch >= 'a' && ch <= 'z')) {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    vowels++;
                else
                    cons++;
            }
        }

        Console.WriteLine("Vowels: " + vowels);
        Console.WriteLine("Consonants: " + cons);
    }
}
