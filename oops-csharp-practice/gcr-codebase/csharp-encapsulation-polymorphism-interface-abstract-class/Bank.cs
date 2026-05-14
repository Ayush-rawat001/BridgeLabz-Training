using System;

public interface ILoanable
{
    void RequestLoan();
    bool VerifyLoanAccess();
}

public abstract class BankAccount : ILoanable
{
    private string accCode;
    private string ownerLabel;
    private double vaultAmount;

    public string AccCode { get { return accCode; } }
    public string OwnerLabel { get { return ownerLabel; } }
    public double VaultAmount { get { return vaultAmount; } }

    public void SetAccCode(string newAcc) { accCode = newAcc; }
    public void SetOwnerLabel(string newName) { ownerLabel = newName; }
    public void SetVaultAmount(double newBal) { vaultAmount = newBal > 0 ? newBal : 0; }

    public void AddFunds(double sum)
    {
        if (sum > 0)
        {
            vaultAmount += sum;
            Console.WriteLine("Amount Added. New Balance → ₹" + vaultAmount);
        }
        else Console.WriteLine("Invalid deposit!");
    }

    public void RemoveFunds(double sum)
    {
        if (sum > 0 && sum <= vaultAmount)
        {
            vaultAmount -= sum;
            Console.WriteLine("Amount Debited. New Balance → ₹" + vaultAmount);
        }
        else Console.WriteLine("Invalid withdraw or low balance!");
    }

    public abstract double ProduceInterest();

    // Loan interface implementation (encapsulated & secured)
    public void RequestLoan()
    {
        Console.WriteLine("\nLoan requested for → " + OwnerLabel);
    }

    public bool VerifyLoanAccess()
    {
        return vaultAmount > 5000; // simple rule
    }

    public bool VerifyLoanAccess(int extra) => VerifyLoanAccess();
}

public class SavingsAccount : BankAccount
{
    public override double ProduceInterest()
    {
        return VaultAmount * 0.04; // 4%
    }
}

public class CurrentAccount : BankAccount
{
    public override double ProduceInterest()
    {
        return VaultAmount * 0.01; // 1%
    }
}

public class BankMenuConsole
{
    private static BankAccount[] bankDesk = new BankAccount[10];
    private static int index = 0;

    public static void CreateSavings()
    {
        if (index >= bankDesk.Length) { Console.WriteLine("Account storage full!\n"); return; }

        SavingsAccount s = new SavingsAccount();
        Console.Write("Enter Account Number: ");
        s.SetAccCode(Console.ReadLine());

        Console.Write("Enter Holder Name: ");
        s.SetOwnerLabel(Console.ReadLine());

        Console.Write("Enter Opening Balance: ");
        s.SetVaultAmount(Convert.ToDouble(Console.ReadLine()));

        bankDesk[index++] = s;
        Console.WriteLine("Savings account created!\n");
    }

    public static void CreateCurrent()
    {
        if (index >= bankDesk.Length) { Console.WriteLine("Account storage full!\n"); return; }

        CurrentAccount c = new CurrentAccount();
        Console.Write("Enter Account Number: ");
        c.SetAccCode(Console.ReadLine());

        Console.Write("Enter Holder Name: ");
        c.SetOwnerLabel(Console.ReadLine());

        Console.Write("Enter Opening Balance: ");
        c.SetVaultAmount(Convert.ToDouble(Console.ReadLine()));

        bankDesk[index++] = c;
        Console.WriteLine("Current account created!\n");
    }

    public static void DepositFlow()
    {
        Console.Write("Enter Account Number to Deposit: ");
        string find = Console.ReadLine();

        for (int i = 0; i < index; i++)
        {
            if (bankDesk[i].AccCode == find)
            {
                Console.Write("Enter Deposit Amount: ");
                bankDesk[i].AddFunds(Convert.ToDouble(Console.ReadLine()));
                return;
            }
        }
        Console.WriteLine("Account not found!\n");
    }

    public static void WithdrawFlow()
    {
        Console.Write("Enter Account Number to Withdraw: ");
        string find = Console.ReadLine();

        for (int i = 0; i < index; i++)
        {
            if (bankDesk[i].AccCode == find)
            {
                Console.Write("Enter Withdraw Amount: ");
                bankDesk[i].RemoveFunds(Convert.ToDouble(Console.ReadLine()));
                return;
            }
        }
        Console.WriteLine("Account not found!\n");
    }

    public static void InterestFlow()
    {
        if (index == 0) { Console.WriteLine("No accounts!\n"); return; }

        Console.WriteLine("\n=== Interest Report ===");
        for (int i = 0; i < index; i++)
        {
            double interest = bankDesk[i].ProduceInterest();
            Console.WriteLine("Acc → " + bankDesk[i].AccCode + " | Holder → " + bankDesk[i].OwnerLabel + " | Interest → ₹" + interest);
        }
        Console.WriteLine();
    }

    public static void LoanFlow()
    {
        Console.Write("Enter Account Number for Loan Check: ");
        string find = Console.ReadLine();

        for (int i = 0; i < index; i++)
        {
            if (bankDesk[i].AccCode == find)
            {
                bankDesk[i].RequestLoan();
                if (bankDesk[i].VerifyLoanAccess())
                    Console.WriteLine("Loan Approved!");
                else
                    Console.WriteLine("Loan Denied!");
                return;
            }
        }
        Console.WriteLine("Account not found!\n");
    }

    public static void ViewAll()
    {
        if (index == 0) { Console.WriteLine("No accounts stored!\n"); return; }

        Console.WriteLine("\n=== Bank Desk Accounts ===");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine($"{i + 1}. Acc → {bankDesk[i].AccCode} | Holder → {bankDesk[i].OwnerLabel} | Balance → ₹{bankDesk[i].VaultAmount}");
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("==== Bank Menu ====");
            Console.WriteLine("1 → Open Savings");
            Console.WriteLine("2 → Open Current");
            Console.WriteLine("3 → Add Money");
            Console.WriteLine("4 → Take Money");
            Console.WriteLine("5 → Show Interest");
            Console.WriteLine("6 → Loan Check");
            Console.WriteLine("7 → View Accounts");
            Console.WriteLine("8 → Exit");
            Console.Write("Choose option: ");

            int call = Convert.ToInt32(Console.ReadLine());

            if (call == 1) CreateSavings();
            else if (call == 2) CreateCurrent();
            else if (call == 3) DepositFlow();
            else if (call == 4) WithdrawFlow();
            else if (call == 5) InterestFlow();
            else if (call == 6) LoanFlow();
            else if (call == 7) ViewAll();
            else if (call == 8) break;
            else Console.WriteLine("Wrong input!\n");
        }

        Console.WriteLine("\nBank Menu Closed.");
    }
}
