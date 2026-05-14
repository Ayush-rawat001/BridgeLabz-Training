using System;

class MoneyProfile
{
    public string profileCode;
    protected string profileOwner;
    private double vaultAmount;

    public MoneyProfile(string code, string owner, double startAmount)
    {
        this.profileCode = code;
        this.profileOwner = owner;
        this.vaultAmount = startAmount;
    }

    public void AddFunds(double cash)
    {
        if (cash > 0) vaultAmount += cash;
    }

    public double ViewFunds() => vaultAmount;
}

class SecureSave : MoneyProfile
{
    public SecureSave(string code, string owner, double startAmount) : base(code, owner, startAmount) { }

    public void PrintProfile()
    {
        Console.WriteLine($"Code: {profileCode} | Owner: {profileOwner}");
    }
}

class LaunchUnit
{
    public static void Main()
    {
        SecureSave save = new SecureSave("MS-9001", "Ankit", 4500);
        save.PrintProfile();
        save.AddFunds(1200);
        Console.WriteLine("Updated Funds: " + save.ViewFunds());
    }
}
