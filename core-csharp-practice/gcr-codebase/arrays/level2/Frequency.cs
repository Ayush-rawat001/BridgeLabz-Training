using System;

class DigitFrequency {
    static void Main() {
        int n = Convert.ToInt32(Console.ReadLine());
        int copy = n;
        int count = 0;

       
        while (copy > 0) {
            copy = copy / 10;
            count = count + 1;
        }

        int[] digits = new int[count];
        int[] freq = new int[10];
        int index = 0;
        copy = n;

        
        while (copy>0) {
            digits[index] = copy % 10;
            copy = copy / 10;
            index = index + 1;
        }

        
        for (int i=0; i<count; i=i+1) {
            int d = digits[i];
            freq[d] = freq[d] + 1;
        }

        
        for (int j = 0; j < 10; j=j+1) {
            if (freq[j] > 0) {
                Console.WriteLine(j);
                Console.WriteLine(freq[j]);
            }
        }
    }
}
