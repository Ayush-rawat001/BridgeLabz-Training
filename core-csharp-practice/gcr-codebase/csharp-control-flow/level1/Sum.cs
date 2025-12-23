using System;
class Sum{
    static void Main(){
        int a= Convert.ToInt32(Console.ReadLine());
        if (a > 0){
            //  formula
            int formula= a * (a + 1) / 2;

            //loop
            int loop= 0;
            int i = 1;
            while (i <= a){
                loop = loop + i;
                i++;
            }
            // Compare results
            if (formula == loop)
            {
                Console.WriteLine("The sum using formula is " + formula);
                Console.WriteLine("The sum using while loop is " + loop);
                Console.WriteLine("Both computations are correct.");
            }
            else
            {
                Console.WriteLine("The results are not matching.");
            }
        }
        else
        {
            Console.WriteLine("The number " + a + " is not a natural number");
        }
    }
}
