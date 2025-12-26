using System;

class FriendStats{
    static void Main(){
        int[] age = new int[3];
        double[] height = new double[3];

        for (int i = 0; i < 3; i++)
        {
            age[i] = int.Parse(Console.ReadLine());
            height[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine(Youngest(age));
        Console.WriteLine(Tallest(height));
    }

    static string Youngest(int[] a){
        string[] names = { "Amar", "Akbar", "Anthony" };
        int minIndex = 0;

        for (int i = 1; i < 3; i++)
            if (a[i] < a[minIndex]) minIndex = i;

        return names[minIndex];
    }

    static string Tallest(double[] h){
        string[] names = { "Amar", "Akbar", "Anthony" };
        int maxIndex = 0;

        for (int i = 1; i < 3; i++)
            if (h[i] > h[maxIndex]) maxIndex = i;

        return names[maxIndex];
    }
}
