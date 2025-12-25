using System;

class ZaraBonus{
    static void Main() {
        double[] salary = new double[10];
        double[] years = new double[10];
        double[] bonus = new double[10];
        double[] newSalary = new double[10];
        double totalBonus = 0, totalOld = 0, totalNew = 0;

        for (int i = 0; i < 10; i++) {
            double sal = Convert.ToDouble(Console.ReadLine());
            if (sal < 0) { i--; 
            continue; 
            }
            salary[i] = sal;
            double yr = Convert.ToDouble(Console.ReadLine());
            if (yr < 0) { i--; 
            continue; 
            }
            years[i] = yr;
            totalOld = totalOld + sal;
        }

        for (int i = 0; i < 10; i++) {
            if (years[i] > 5) bonus[i] = salary[i] * 0.05;
            else bonus[i] = salary[i] * 0.02;
            newSalary[i] = salary[i] + bonus[i];
            totalBonus = totalBonus + bonus[i];
            totalNew = totalNew + newSalary[i];
        }

        for (int i = 0; i < 10; i++) {
            Console.WriteLine((i+1) + " " + years[i] + " " + salary[i] + " " + bonus[i] + " " + newSalary[i]);
        }

        Console.WriteLine(totalBonus);
        Console.WriteLine(totalOld);
        Console.WriteLine(totalNew);
    }
}
