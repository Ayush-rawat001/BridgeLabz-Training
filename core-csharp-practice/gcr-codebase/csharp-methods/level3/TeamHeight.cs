using System;

class TeamHeights{
    static void Main(){
        int[] heights = new int[11];
        Random rnd = new Random();

       
        for (int i = 0; i < heights.Length; i++){
            heights[i] = rnd.Next(150, 251);
        }

        int sum = FindSum(heights);
        double mean = FindMean(sum, heights.Length);
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);

        Console.WriteLine("Heights: " + string.Join(", ", heights));
        Console.WriteLine("Mean height: " + mean);
        Console.WriteLine("Shortest height: " + shortest);
        Console.WriteLine("Tallest height: " + tallest);
    }

    static int FindSum(int[] arr) {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++){
            sum += arr[i];
        }
        return sum;
    }

    static double FindMean(int sum, int count){
        return sum / (double)count;
    }

    static int FindShortest(int[] arr){
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++){
            if (arr[i] < min) min = arr[i];
        }
        return min;
    }

    static int FindTallest(int[] arr){
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] > max) max = arr[i];
        }
        return max;
    }
}
