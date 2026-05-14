namespace LoanBuddy
{
    public class AutoLoan : LoanApplication
    {
        public AutoLoan(Applicant applicant)
            : base(applicant, "Auto Loan", 60, 10.5)
        {
        }

        // Different EMI logic
        public override bool ApproveLoan()
        {
            return InternalApprovalCheck();
        }

        public override double CalculateEMI()
        {
            double baseEmi = CalculateBaseEMI();

            // Auto loan insurance surcharge
            return baseEmi + 500;
        }
    }
}
