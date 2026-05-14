using System;

class TeamBMI{
    static void Main(){
        double[,] data = new double[10, 3];

        for (int i = 0; i < 10; i++){
            data[i, 0] = double.Parse(Console.ReadLine());
            data[i, 1] = double.Parse(Console.ReadLine());
        }

        FillBMI(data);
        string[] status = GetStatus(data);

        for (int i = 0; i < 10; i++){
            Console.WriteLine(data[i, 1] + " " + data[i, 0] + " " + data[i, 2] + " " + status[i]);
        }
    }

    static void FillBMI(double[,] arr){
        for (int i = 0; i < 10; i++){
            double hMeter = arr[i, 1] / 100;
            arr[i, 2] = arr[i, 0] / (hMeter * hMeter);
        }
    }

    static string[] GetStatus(double[,] arr){
        string[] s = new string[10];

        for (int i = 0; i < 10; i++){
            double bmi = arr[i, 2];
            if (bmi < 18.5) s[i] = "UnderWeight";
            else if (bmi >= 18.5 && bmi < 24.9) s[i] = "Normal";
            else if (bmi >= 25 && bmi < 29.9) s[i] = "OverWeight";
            else s[i] = "Obese";
        }

        return s;
    }
}
