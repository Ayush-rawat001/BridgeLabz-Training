using System;

class AmarAkbarAnthony {
    static void Main() {
        double[] age = new double[3];
        double[] height = new double[3];

        for (int i = 0; i < 3; i++) {
            age[i] = Convert.ToDouble(Console.ReadLine());
            height[i] = Convert.ToDouble(Console.ReadLine());
            }

        int young = 0;
        int tall = 0;

        for (int i = 1; i < 3; i++) {
            if (age[i] < age[young]) {
                young = i;
                }
            if (height[i] > height[tall]) {
                tall = i;
                }
        }

        string[] name = { "Amar", "Akbar", "Anthony" };
        Console.WriteLine(name[young]);
        Console.WriteLine(name[tall]);
    }
}
