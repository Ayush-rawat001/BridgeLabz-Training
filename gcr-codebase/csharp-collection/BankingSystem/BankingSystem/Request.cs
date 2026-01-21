using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem.BankingSystem
{
    internal class Request
    {
        public int AccountNum;
        public double Withdrawl;

        public Request(int accountnum,double withdrawl)
        {
            AccountNum = accountnum;
            Withdrawl = withdrawl;
        }
    }
}
