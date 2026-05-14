using System;

class Sum{
    static void Main(){
        double[] arr=new double[10];
        double total=0.0;
        int idx=0;
        while (true){
             double num = Convert.ToDouble(Console.ReadLine());
             if (num <= 0 || idx == 10){
                break;
            }
            arr[idx]=num;
            idx++;
        }
        

        for (int i = 0; i < idx; i++){
            total = total + arr[i];
        }

        Console.WriteLine("sum: "+total);
    }
}
