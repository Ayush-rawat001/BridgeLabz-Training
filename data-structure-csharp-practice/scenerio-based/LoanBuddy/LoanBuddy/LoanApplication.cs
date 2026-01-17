using System;

namespace LoanBuddy
{
    public abstract class LoanApplication : IApprovable
    {
        protected string loanType;
        protected int term; // months
        protected double interestRate;

        protected Applicant applicant;

        private bool loanApproved = false;

        protected LoanApplication(Applicant applicant,
                                  string loanType,
                                  int term,
                                  double interestRate)
        {
            this.applicant = applicant;
            this.loanType = loanType;
            this.term = term;
            this.interestRate = interestRate;
        }

        // EMI formula
        protected double CalculateBaseEMI()
        {
            double P = applicant.LoanAmount;
            double R = interestRate / (12 * 100);
            int N = term;

            return (P * R * Math.Pow(1 + R, N)) /
                   (Math.Pow(1 + R, N) - 1);
        }

        // Private approval logic
        protected bool InternalApprovalCheck()
        {
            if (applicant.GetCreditScore() >= 700 &&
                applicant.Income >= applicant.LoanAmount / 10)
            {
                loanApproved = true;
            }

            return loanApproved;
        }

        protected bool GetLoanStatus()
        {
            return loanApproved;
        }

        public abstract bool ApproveLoan();
        public abstract double CalculateEMI();
    }
}
