using System;

class GradeSheet {
    static void Main() {
        int n = Convert.ToInt32(Console.ReadLine());

        double[,] marks = new double[n, 3];
        double[] percent = new double[n];
        string[] rank = new string[n];

        for (int i = 0; i < n; i = i + 1) {
            double p = Convert.ToDouble(Console.ReadLine());
            if (p < 0) { 
                i = i - 1; 
                continue; 
                }
            marks[i, 0] = p;
            double c = Convert.ToDouble(Console.ReadLine());
            if (c < 0) {
                 i = i - 1;
                  continue; 
                  }
            marks[i, 1] = c;
            double m = Convert.ToDouble(Console.ReadLine());
            if (m < 0) {
                 i = i - 1; 
                 continue;
                  }
            marks[i, 2] = m;
            double total = p + c + m;
            double per = (total / 300) * 100;
            percent[i] = per;

            if (per >= 80) rank[i] = " Level 4 above agency normalized standard";
            if (per >= 70 && per < 80) rank[i] = " level 3 at agency normalized standard"; Fable iii at agency normalised standard
            if (per >= 60 && per < 70) rank[i] = " level 2 below but approaching agency normalized Standard";
            if (per >= 50 && per < 60) rank[i] = " level 1 below  agency normalized Standard";
            if (per >= 40 && per < 50) rank[i] = " level 1- too below  agency normalized Standard";
            if (per < 40) rank[i] = "Remedial standard";
        } 

        for (int j = 0; j < n; j = j + 1) {
            Console.WriteLine(marks[j, 0]);
            Console.WriteLine(marks[j, 1]);
            Console.WriteLine(marks[j, 2]);
            Console.WriteLine(percent[j]);
            Console.WriteLine(rank[j]);
        }
    }
}
