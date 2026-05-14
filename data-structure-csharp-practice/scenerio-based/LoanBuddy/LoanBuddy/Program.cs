using System;

namespace LoanBuddy
{
    class Program
    {
        static void Main()
        {
            Applicant applicant =
                new Applicant("Rahul", 750, 80000, 500000);

            LoanApplication homeLoan =
                new HomeLoan(applicant);

            LoanApplication autoLoan =
                new AutoLoan(applicant);

            Console.WriteLine("Applicant Name: " + applicant.Name);
            Console.WriteLine();

            // Home Loan
            if (homeLoan.ApproveLoan())
            {
                Console.WriteLine("✅ Home Loan Approved");
                Console.WriteLine("EMI: " + homeLoan.CalculateEMI());
            }
            else
            {
                Console.WriteLine("❌ Home Loan Rejected");
            }

            Console.WriteLine("------------------------");

            // Auto Loan
            if (autoLoan.ApproveLoan())
            {
                Console.WriteLine("✅ Auto Loan Approved");
                Console.WriteLine("EMI: " + autoLoan.CalculateEMI());
            }
            else
            {
                Console.WriteLine("❌ Auto Loan Rejected");
            }
        }
    }
}
