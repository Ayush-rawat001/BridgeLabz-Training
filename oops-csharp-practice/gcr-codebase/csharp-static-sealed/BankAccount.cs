using System;

class BankAccount
{
    // static variable (shared)
    public static string bankName = "Unity National Bank";
    private static int totalAccounts = 0;

    // readonly variable (cannot change after assignment)
    public readonly string accountNumber;

    // normal variables
    public string accountHolderName;
    public double balance;

    
    public BankAccount(string accountHolderName, string accountNumber, double balance)
    {
        this.accountHolderName = accountHolderName; // using this keyword
        this.accountNumber = accountNumber;         // readonly assigned only here
        this.balance = balance;
        totalAccounts++;
    }

    // static method
    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts in " + bankName + " : " + totalAccounts);
    }

    // deposit method
    public void AddDeposit(double amount)
    {
        if (amount > 0) this.balance += amount;
    }

    // show details method
    public void PrintDetails()
    {
        Console.WriteLine("\n--- Account Details ---");
        Console.WriteLine("Bank Name : " + bankName);
        Console.WriteLine("Holder    : " + accountHolderName);
        Console.WriteLine("Acc No.   : " + accountNumber);
        Console.WriteLine("Balance   : " + balance);
        Console.WriteLine("----------------------");
    }
}

class RunApp
{
    public static void Main()
    {
        Console.WriteLine("Enter Account Holder Name:");
        string hName = Console.ReadLine();

        Console.WriteLine("Enter Account Number:");
        string accNo = Console.ReadLine();

        Console.WriteLine("Enter Initial Balance:");
        double bal = Convert.ToDouble(Console.ReadLine());

        BankAccount userAcc = new BankAccount(hName, accNo, bal);

        userAcc.AddDeposit(1000); // sample deposit
        Console.WriteLine("\nChecking instance using 'is' operator...");

        // is operator check
        if (userAcc is BankAccount)
        {
            Console.WriteLine("Yes, object belongs to BankAccount class.");
            userAcc.PrintDetails();
        }

        // static method call
        BankAccount.GetTotalAccounts();
    }
}
