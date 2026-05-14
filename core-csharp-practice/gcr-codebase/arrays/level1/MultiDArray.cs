using System;

class MultiDArray{
    static void Main(){
        int r = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[r, c];
        for (int i = 0; i < r; i++){
            for (int j = 0; j < c; j++){
               matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int[] array = new int[r * c];

        int idx = 0;

        for (int i = 0; i < r; i++){
            for (int j = 0; j < c; j++){
                array[idx] = matrix[i, j];
                idx++;
            }
        }

       
        for (int i = 0; i < array.Length; i++){
            Console.Write(array[i]+" ");
        }
    }
}
