using System;
class OddEven{
    static void Main(){
        int size= Convert.ToInt32(Console.ReadLine());
        int[] input=new int[size];
        int evenSize=0;
        int oddSize=0;
        for(int i=0;i<size;i++){
            input[i]=Convert.ToInt32(Console.ReadLine());
            if(input[i]%2==0){
                evenSize++;
            }
            else{
                oddSize++;
            }
        }
         int[] even=new int[evenSize];
          int[] odd=new int[oddSize];

int k=0;
int j=0;

        for(int i=0;i<size;i++){
             if(input[i]%2==0){
                even[k]=input[i];
                k++;
            }
            else{
               odd[j]=input[i];
               j++;
            }
        }
 Console.WriteLine("even array");
        for(int i=0;i<evenSize;i++){
           
             Console.Write(even[i]+" ");
        }
         Console.WriteLine();
         Console.WriteLine("odd array");
         for(int i=0;i<oddSize;i++){
           
             Console.Write(odd[i]+" ");
        }


    }
}