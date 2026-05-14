using System;

class Mean{
    static void Main(){
        double[] height = new double[11];
        
        for (int i = 0; i < height.Length; i++){
        height[i] = Convert.ToDouble(Console.ReadLine());
        }
           double sum = 0.0;
        for (int i = 0; i < height.Length; i++){
            sum = sum + height[i];
        }
        double mean = sum / 11;
     
          Console.WriteLine("Mean height " + mean + " cm");
    }
}
