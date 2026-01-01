using System;

class TempAnalyzer{
    // analyze temps
    public static void CheckWeek(float[,] temps){
        float hotSum = 0, coldSum = 0;
        float[] avg = new float[7];

        float hot = temps[0,0];
        float cold = temps[0,0];

        int hotDay = 0, coldDay = 0;

        for (int d = 0; d < 7; d++){
            float sum = 0;

            for (int h = 0; h < 24; h++){
                float t = temps[d,h];
                sum = sum + t;

                if (t > hot){
                    hot = t;
                    hotDay = d;
                }

                if (t < cold){
                    cold = t;
                    coldDay = d;
                }
            }

            avg[d] = sum / 24;
        }

        Console.WriteLine("Hottest day: Day " + (hotDay+1));
        Console.WriteLine("Coldest day: Day " + (coldDay+1));

        Console.WriteLine("\nAverage temps:");
        for (int i = 0; i < 7; i++){
            Console.WriteLine("Day " + (i+1) + " = " + avg[i]);
        }
    }

    // start
    public static void Main() {
        float[,] temps = new float[7,24];

        Console.WriteLine("Enter 7 days hourly temps:");

        for (int d = 0; d < 7; d++){
            Console.WriteLine("\nDay " + (d+1));

            for (int h = 0; h < 24; h++) {
                temps[d,h] = Convert.ToSingle(Console.ReadLine());
            }
        }

        CheckWeek(temps);
    }
}
