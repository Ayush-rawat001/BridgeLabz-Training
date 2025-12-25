using System;

class FlipNumber {
    static void Main() {
        int num = Convert.ToInt32(Console.ReadLine());
        int copy = num;
        int count = 0;

        while (copy > 0) {
            copy = copy / 10;
            count = count + 1;
        }

        int[] dig = new int[count];
        int[] back = new int[count];
        int p = 0;

        while (num > 0) {
            dig[p] = num % 10;
            num = num / 10;
            p = p + 1;
        }

        for (int q = 0; q < count; q = q + 1) {
            back[q] = dig[count - q - 1];
        }

        for (int m = 0; m < count; m = m + 1) {
            Console.WriteLine(back[m]);
        }
    }
}
