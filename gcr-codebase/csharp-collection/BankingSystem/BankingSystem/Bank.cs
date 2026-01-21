using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem.BankingSystem
{
    internal class Bank
    {
        public int AccountNumber;
        public string Name;
        public double Balance;

        public Bank(int accountnumber,string name, double balance)
        {
            AccountNumber = accountnumber;
            Name = name;
            Balance = balance;

        }
    }
}
