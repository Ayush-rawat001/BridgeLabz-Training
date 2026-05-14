using System;
class DigitStore {
    static void Main() {
        int num = Convert.ToInt32(Console.ReadLine());
        int limit = 10;
        int[] arr = new int[limit];
        int i = 0;

        while (num != 0) {
            if (i == limit) break;
            arr[i] = num % 10;
            num = num / 10;
            i = i + 1;
        }

        int max = 0, secMax = 0;

        for (int j = 0; j < i; j = j + 1) {
            if (arr[j] > max) {
                secMax = max;
                max = arr[j];
            }
            if (arr[j] > secMax && arr[j] < max) {
                secMax = arr[j];
            }
        }

        Console.WriteLine(max);
        Console.WriteLine(secMax);
    }
}
