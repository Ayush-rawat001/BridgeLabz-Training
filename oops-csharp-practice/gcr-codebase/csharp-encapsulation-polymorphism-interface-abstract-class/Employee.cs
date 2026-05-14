using System;

// Department interface (polymorphism support)
public interface ISection
{
    void ConnectSection(string secTitle);
    string FetchSectionReport();
}

// Abstract base class for employees
public abstract class WorkerBase
{
    private int tagNumber;
    private string fullLabel;
    private double startingAmount;

    // Encapsulated properties
    public int TagNumber
    {
        get { return tagNumber; }
        set { tagNumber = value; }
    }

    public string FullLabel
    {
        get { return fullLabel; }
        set { fullLabel = value; }
    }

    public double StartingAmount
    {
        get { return startingAmount; }
        set { startingAmount = value; }
    }

    // Abstract salary calculator
    public abstract double GenerateIncomeSlip();

    // Concrete display method
    public void RevealWorkerCard()
    {
        Console.WriteLine("\n=== Worker Identity Card ===");
        Console.WriteLine("Tag ID      → " + TagNumber);
        Console.WriteLine("Identity    → " + FullLabel);
        Console.WriteLine("Initial Pay → ₹" + StartingAmount);
        Console.WriteLine("Total Earn  → ₹" + GenerateIncomeSlip());
    }
}

// Full time employee type
public class FixedWorker : WorkerBase, ISection
{
    private string secName;
    private double extraReward;

    public double ExtraReward
    {
        get { return extraReward; }
        set { extraReward = value; }
    }

    public override double GenerateIncomeSlip()
    {
        return StartingAmount + ExtraReward;
    }

    public void ConnectSection(string secTitle)
    {
        secName = secTitle;
    }

    public string FetchSectionReport()
    {
        return "Section Linked → " + secName + " [Fixed Worker]";
    }
}

// Part time employee type
public class TimeBasedWorker : WorkerBase, ISection
{
    private string secName;
    private int shiftLength;
    private const int singleHourValue = 140;

    public int ShiftLength
    {
        get { return shiftLength; }
        set { shiftLength = value; }
    }

    public override double GenerateIncomeSlip()
    {
        return ShiftLength * singleHourValue;
    }

    public void ConnectSection(string secTitle)
    {
        secName = secTitle;
    }

    public string FetchSectionReport()
    {
        return "Section Linked → " + secName + " [Time Worker: " + ShiftLength + " hrs]";
    }
}

// Main execution class
public class Engine
{
    public static void Main()
    {
        WorkerBase[] registerDesk = new WorkerBase[2];

        // Creating fixed salary worker
        FixedWorker wA = new FixedWorker();
        wA.TagNumber = 9001;
        wA.FullLabel = "Aarav Mehta";
        wA.StartingAmount = 28000;
        wA.ExtraReward = 4500;
        wA.ConnectSection("Innovation Hub");

        // Creating part-time worker
        TimeBasedWorker wB = new TimeBasedWorker();
        wB.TagNumber = 9002;
        wB.FullLabel = "Sara Khan";
        wB.StartingAmount = 0;
        wB.ShiftLength = 120;
        wB.ConnectSection("Help Desk");

        registerDesk[0] = wA;
        registerDesk[1] = wB;

        Console.WriteLine("Launching Worker Registry...\n");

        foreach (WorkerBase unit in registerDesk)
        {
            unit.RevealWorkerCard();

            if (unit is ISection sec)
            {
                Console.WriteLine(sec.FetchSectionReport());
            }
        }

        Console.WriteLine("\nRegistry Closed Successfully.");
    }
}
