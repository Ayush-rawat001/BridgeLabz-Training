using System;

class RandomStats{
    static void Main(){
        int[] numbers = Generate4DigitRandomArray(5);
        double[] results = FindAverageMinMax(numbers);

     for (int i = 0; i < numbers.Length; i++)
            Console.Write(numbers[i] + " ");
        Console.WriteLine();

        
        Console.WriteLine(results[0]);
        Console.WriteLine(results[1]);
        Console.WriteLine(results[2]);
    }

    public static int[] Generate4DigitRandomArray(int size){
        int[] arr = new int[size];
        Random rnd = new Random();

        for (int i = 0; i < size; i++)
            arr[i] = rnd.Next(1000, 10000); 

        return arr;
    }

    public static double[] FindAverageMinMax(int[] numbers){
        int min = numbers[0];
        int max = numbers[0];
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++){
            sum += numbers[i];
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }

        double avg = sum / (double)numbers.Length;
        return new double[] { avg, min, max };
    }
}
