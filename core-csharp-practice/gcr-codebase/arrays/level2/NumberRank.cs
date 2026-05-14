using System;

class NumberRank {
    static void Main() {
        int n = Convert.ToInt32(Console.ReadLine());
        int size = 10;
        int[] store = new int[size];
        int pos = 0;

        while (n > 0) {
            if (pos == size) {
                size = size + 10;
                int[] hold = new int[size];

                for (int t = 0; t < store.Length; t = t + 1) {
                    hold[t] = store[t];
                }
                store = hold;
            }

            store[pos] = n % 10;
            n = n / 10;
            pos = pos + 1;
        }

        int top = 0, runner = 0;

        for (int r = 0; r < pos; r = r + 1) {
            if (store[r] > top) {
                runner = top;
                top = store[r];
            }
            if (store[r] > runner && store[r] != top) {
                runner = store[r];
            }
        }

        Console.WriteLine(top);
        Console.WriteLine(runner);
    }
}
