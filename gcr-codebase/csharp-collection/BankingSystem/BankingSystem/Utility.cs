using System;
using System.Collections.Generic;

namespace BankingSystem.BankingSystem
{
    internal class Utility
    {
        // Dictionary to store account number and Bank object
        private Dictionary<int, Bank> accounts = new Dictionary<int, Bank>();

        // Add user
        public void AddUser()
        {
            Console.Write("Enter Account Number: ");
            int accNum = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Balance: ");
            double balance = double.Parse(Console.ReadLine());

            if (!accounts.ContainsKey(accNum))
            {
                Bank bank = new Bank(accNum, name, balance);
                accounts.Add(accNum, bank);
                Console.WriteLine("User added successfully!\n");
            }
            else
            {
                Console.WriteLine("Account number already exists.\n");
            }
        }

        // Sort users by balance
        public void sort()
        {
            // SortedDictionary to sort by balance
            SortedDictionary<double, List<Bank>> sorted = new SortedDictionary<double, List<Bank>>();

            foreach (var acc in accounts.Values)
            {
                if (!sorted.ContainsKey(acc.Balance))
                    sorted[acc.Balance] = new List<Bank>();

                sorted[acc.Balance].Add(acc);
            }

            Console.WriteLine("\nUsers sorted by balance:");
            foreach (var kvp in sorted)
            {
                foreach (var user in kvp.Value)
                {
                    Console.WriteLine($"Account: {user.AccountNumber}, Name: {user.Name}, Balance: {user.Balance}");
                }
            }
            Console.WriteLine();
        }

        // Process multiple withdrawal requests using Queue
        public void MultipleWithdraw(Queue<Request> reqQueue)
        {
            while (reqQueue.Count > 0)
            {
                Request req = reqQueue.Dequeue();
                if (accounts.ContainsKey(req.AccountNum))
                {
                    Bank user = accounts[req.AccountNum];
                    if (user.Balance >= req.Withdrawl)
                    {
                        user.Balance -= req.Withdrawl;
                        Console.WriteLine($"Withdrawal successful for {user.Name}. New Balance: {user.Balance}");
                    }
                    else
                    {
                        Console.WriteLine($"Insufficient balance for {user.Name}. Current Balance: {user.Balance}");
                    }
                }
                else
                {
                    Console.WriteLine($"Account number {req.AccountNum} not found.");
                }
            }
            Console.WriteLine();
        }
    }
}
