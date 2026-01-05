using System;

class WorkMember
{
    public int tagNumber;
    protected string unitSection;
    private double payAmount;

    public WorkMember(int t, string u, double p)
    {
        this.tagNumber = t;
        this.unitSection = u;
        this.payAmount = p;
    }

    public void RevisePay(double newPay)
    {
        if (newPay > 0) this.payAmount = newPay;
    }

    public void AnnouncePay() => Console.WriteLine("Salary is locked in the system");
}

class TeamLead : WorkMember
{
    public TeamLead(int t, string u, double p) : base(t, u, p) { }

    public void LeadSummary()
    {
        Console.WriteLine($"Lead Tag: {tagNumber} supervises {unitSection} unit.");
    }
}

class RunHub
{
    public static void Main()
    {
        TeamLead lead = new TeamLead(777, "Network Division", 62000);
        lead.LeadSummary();
        lead.RevisePay(70000);
        Console.WriteLine("Salary updated successfully");
    }
}
