using System;

class LearnTrack
{
    // instance variables
    public string program;
    public int period;
    public double charges;

    // class variable
    public static string center = "gla university";

    // constructor
    public LearnTrack(string program, int period, double charges)
    {
        this.program = program;
        this.period = period;
        this.charges = charges;
    }

    // instance method
    public void PrintCourse()
    {
        Console.WriteLine("\nInstitute : " + center);
        Console.WriteLine("Course    : " + program);
        Console.WriteLine("Duration  : " + period + " months");
        Console.WriteLine("Fee       : ₹" + charges);
    }

    // class method
    public static void ChangeInstitute(string newName)
    {
        center = newName;
    }
}

class RunApp
{
    public static void Main()
    {
        Console.WriteLine(" institute name: ");
        string ins = Console.ReadLine();
        LearnTrack.ChangeInstitute(ins);

        Console.WriteLine("Enter course name: ");
        string c = Console.ReadLine() ;

        Console.WriteLine("Enter duration: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter fee:");
        double f = Convert.ToDouble(Console.ReadLine());

        LearnTrack t = new LearnTrack(c, m, f);
        t.PrintCourse();
    }
}
