using System;

class BMIGrid {
    static void Main() {
        int n = Convert.ToInt32(Console.ReadLine());

        double[,] data = new double[n, 3];
        string[] type = new string[n];

        for (int i = 0; i < n; i = i + 1) {
            double h = Convert.ToDouble(Console.ReadLine());
            if (h <= 0) {
                i = i - 1;
                continue;
            }

            double w = Convert.ToDouble(Console.ReadLine());
            if (w <= 0) {
                i = i - 1;
                continue;
            }

            double m = h / 100;
            double b = w / (m * m);

            data[i, 0] = h;
            data[i, 1] = w;
            data[i, 2] = b;

            if (b < 18.5) type[i] = "Underweight";
            if (b >= 18.5 && b < 25) type[i] = "normal";
            if (b >= 25 && b < 30) type[i] = "overweight";
            if (b >= 30) type[i] = "overweight";
        }

        for (int j = 0; j < n; j = j + 1) {
            Console.WriteLine(data[j, 0]);
            Console.WriteLine(data[j, 1]);
            Console.WriteLine(data[j, 2]);
            Console.WriteLine(type[j]);
        }
    }
}
