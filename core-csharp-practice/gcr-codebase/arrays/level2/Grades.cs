using System;

class Grades {
    static void Main() {
        int n = Convert.ToInt32(Console.ReadLine());
        double[,] marks = new double[n, 3];  
        double[] percent = new double[n];
        string[] grade = new string[n];

        for (int i = 0; i < n; i = i + 1) {
            double phy = Convert.ToDouble(Console.ReadLine());
            if (phy < 0) { i = i - 1; continue; }
            marks[i, 0] = phy;
            double chem = Convert.ToDouble(Console.ReadLine());
            if (chem < 0) { i = i - 1;
             continue;
              }
            marks[i, 1] = chem;
            double math = Convert.ToDouble(Console.ReadLine());
            if (math < 0) { i = i - 1;
             continue;
              }
            marks[i, 2] = math;
            double total = marks[i, 0] + marks[i, 1] + marks[i, 2];
            double per = (total / 300) * 100;
            percent[i] = per;

             if (per >= 80) grade[i] = " Level 4 above agency normalized standard";
            if (per >= 70 && per < 80) grade[i] = " level 3 at agency normalized standard";
            if (per >= 60 && per < 70) grade[i] = " level 2 below but approaching agency normalized Standard";
            if (per >= 50 && per < 60) grade[i] = " level 1 below  agency normalized Standard";
            if (per >= 40 && per < 50) grade[i] = " level 1- too below  agency normalized Standard";
            if (per < 40) grade[i] = "Remedial standard";
        }

        for (int j = 0; j < n; j = j + 1) {
            Console.WriteLine(marks[j, 0]);
            Console.WriteLine(marks[j, 1]);
            Console.WriteLine(marks[j, 2]);
            Console.WriteLine(percent[j]);
            Console.WriteLine(grade[j]);
        }
    }
}
