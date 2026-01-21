using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem.BankingSystem
{
    internal class Menu
    {
        public void Start()
        {
            Utility util = new Utility();
            while(true)
            {
               
                Console.WriteLine("press 1 to add user");
                Console.WriteLine("press 2 to sort user on thoe basis of balance");
                Console.WriteLine("press 3 for multiple queue request");
                Console.WriteLine("press 4 for exit");

                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        util.AddUser();
                        break;
                    case 2:
                        util.sort();
                        break;
                    case 3:
                        Queue < Request > req= new Queue<Request>();
                      
                        Console.Write("How Many Request :");
                        int NumOfReq = int.Parse(Console.ReadLine());
                        for(int i = 0;i < NumOfReq;i++)
                        {
                            Console.Write(" Account number "+(i + 1)+ " :" );
                            int AccNum = int.Parse(Console.ReadLine());
                            Console.WriteLine("how much Amt to withdraw");
                            double Amt = int.Parse(Console.ReadLine());
                            req.Enqueue(new Request(AccNum, Amt));
                        }


                        util.MultipleWithdraw(req);
                        break;
                    case 4:
                        return;
                }

            }
        }

    }
}
