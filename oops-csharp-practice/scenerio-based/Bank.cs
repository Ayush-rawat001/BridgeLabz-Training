using System;

class BankAccount
{
    public string AccountNumber;
    public double Balance;

    public BankAccount(string accNumber, double initialBalance)
    {
        this.AccountNumber = accNumber;
        this.Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine("Deposit Successful! New Balance: " + Balance);
        }
        else
        {
            Console.WriteLine("Invalid Deposit Amount!");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid Withdrawal Amount!");
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Transaction Failed! Insufficient Balance (Overdraft Not Allowed)");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine("Withdrawal Successful! Remaining Balance: " + Balance);
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine("Current Account Balance: " + Balance);
    }
}

class Program
{
    static void Main()
    {
        BankAccount userAcc = new BankAccount("AX1001", 0);

        while (true)
        {
            Console.WriteLine("\n===== BANK MENU =====");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter deposit amount: ");
                    double depAmount = Convert.ToDouble(Console.ReadLine());
                    userAcc.Deposit(depAmount);
                    break;

                case 2:
                    Console.Write("Enter withdrawal amount: ");
                    double withAmount = Convert.ToDouble(Console.ReadLine());
                    userAcc.Withdraw(withAmount);
                    break;

                case 3:
                    Console.WriteLine("Account Number: " + userAcc.AccountNumber);
                    userAcc.CheckBalance();
                    break;

                case 4:
                    Console.WriteLine("Thank you for using the Bank App!");
                    return;

                default:
                    Console.WriteLine("Invalid Option! Try again.");
                    break;
            }
        }
    }
}
