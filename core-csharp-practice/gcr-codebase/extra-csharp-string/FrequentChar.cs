using System;
class FrequentChar {
    static void Main() {
        
        string str = Console.ReadLine();
        char max = ' ';
        int maxCount = 0;

        for (int i = 0; i < str.Length; i++) {
            int count = 0;
            for (int j = 0; j < str.Length; j++) {
                if (str[i] == str[j]) count++;
            }
            if (count > maxCount) {
                maxCount = count;
                max = str[i];
            }
        }

        Console.WriteLine("Most Frequent Character: " + max);
    }
}
