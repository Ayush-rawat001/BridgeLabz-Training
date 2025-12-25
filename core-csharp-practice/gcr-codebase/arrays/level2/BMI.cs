using System;

class BMI {
    static void Main() {
        int total = Convert.ToInt32(Console.ReadLine());
        double[] mass = new double[total];
        double[] tall = new double[total];
        double[] score = new double[total];
        string[] tag = new string[total];

        for (int i = 0; i < total; i = i + 1){
            mass[i] = Convert.ToDouble(Console.ReadLine());
            tall[i] = Convert.ToDouble(Console.ReadLine());
        }

        for (int i = 0; i < total; i = i + 1){
            double h = tall[i] * 0.01;
            double ans = mass[i] / (h * h);
            score[i] = ans;
            if (ans < 18.5) {
                tag[i] = "Underweight";
            }
            if (ans >= 18.5 && ans < 24.9) {
                tag[i] = "normal";
            }
            if (ans >= 24.9 && ans < 29.9) {
                tag[i] = "overweight";
            }
            if (ans >= 29.9) {
                tag[i] = "overweight";
            }
        }

        for (int i = 0; i < total; i = i + 1) {
            Console.WriteLine(tall[i]);
            Console.WriteLine(mass[i]);
            Console.WriteLine(score[i]);
            Console.WriteLine(tag[i]);
        }
    }
}
