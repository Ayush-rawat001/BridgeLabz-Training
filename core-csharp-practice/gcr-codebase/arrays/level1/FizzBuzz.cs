using System;

class FizzBuzz{
    static void Main(){
    int num = Convert.ToInt32(Console.ReadLine());
    if (num <= 0){
            return;
        }

        string[] res = new string[num + 1];

        for (int i = 0; i <= num; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                res[i] = "FizzBuzz";
            else if (i % 3 == 0)
                res[i] = "Fizz";
            else if (i % 5 == 0)
                res[i] = "Buzz";
            else
                res[i] = i+"";
        }

        
        for (int i = 1; i < res.Length; i++) {
            Console.WriteLine(i+" = "+res[i]);
        }
    }
}
