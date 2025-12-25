using System;

class Factor{
    static void Main(){
    int num = Convert.ToInt32(Console.ReadLine());
    int maxFactor = 10;
    int[] fac = new int[maxFactor];
    int idx = 0;
    for (int i = 1; i <= num; i++){
            if (num % i == 0){
                if (idx == maxFactor){
                    maxFactor = maxFactor * 2;
                    int[] temp = new int[maxFactor];

                    for (int j = 0; j < fac.Length; j++){
                        temp[j] = fac[j];
                    }
                    fac = temp;
                }
                fac[idx] = i;
                idx++;
            }
        }

      
        for (int i = 0; i < idx; i++)
        {
            Console.WriteLine(fac[i]);
        }
    }
}
