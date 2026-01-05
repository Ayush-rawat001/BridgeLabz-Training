using System;

class Learner
{
    public int badgeCode;
    protected string fullName;
    private double scoreIndex;

    public Learner(int badgeCode, string fullName, double scoreIndex)
    {
        this.badgeCode = badgeCode;
        this.fullName = fullName;
        this.scoreIndex = scoreIndex;
    }

    public void ModifyScore(double updatedScore)
    {
        if (updatedScore >= 0 && updatedScore <= 10)
            this.scoreIndex = updatedScore;
    }

    public double FetchScore() => this.scoreIndex;

    public void PrintLearner()
    {
        Console.WriteLine("\nID   : " + badgeCode);
        Console.WriteLine("Name : " + fullName);
        Console.WriteLine("Score: " + scoreIndex);
    }
}

class AdvancedLearner : Learner
{
    public AdvancedLearner(int code, string nm, double sc) : base(code, nm, sc) { }

    public void PrintAdvanced()
    {
        Console.WriteLine($"\nPost Grad Learner: {fullName} (ID: {badgeCode})");
    }
}

class RunnerApp
{
    public static void Main()
    {
        AdvancedLearner obj = new AdvancedLearner(202, "Karan", 7.8);
        Console.WriteLine("Initial Score: " + obj.FetchScore());

        obj.ModifyScore(8.6);
        Console.WriteLine("Revised Score: " + obj.FetchScore());

        obj.PrintAdvanced();
        obj.PrintLearner();
    }
}
