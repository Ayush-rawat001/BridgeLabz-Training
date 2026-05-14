namespace LoanBuddy
{
    public class HomeLoan : LoanApplication
    {
        public HomeLoan(Applicant applicant)
            : base(applicant, "Home Loan", 240, 8.5)
        {
        }

        // Polymorphism
        public override bool ApproveLoan()
        {
            return InternalApprovalCheck();
        }

        public override double CalculateEMI()
        {
            return CalculateBaseEMI();
        }
    }
}
