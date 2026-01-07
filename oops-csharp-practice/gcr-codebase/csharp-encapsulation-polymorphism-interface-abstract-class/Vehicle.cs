using System;

// Insurance interface
public interface IInsurable
{
    double ComputeCoverageCharge();
    string ShowCoveragePlan();
}

// Abstract vehicle class
public abstract class TransportUnit
{
    private string regMark;
    private string category;
    private double dayCharge;
    private string secretPolicyCode;

    public string RegMark { get { return regMark; } }
    public string Category { get { return category; } }
    public double DayCharge { get { return dayCharge; } }

    public void UpdateRegMark(string newReg) { regMark = newReg; }
    public void UpdateCategory(string newType) { category = newType; }
    public void UpdateDayCharge(double newRate) { dayCharge = newRate > 0 ? newRate : 0; }
    public void StorePolicyCode(string policy) { secretPolicyCode = policy; }
    public string AccessPolicyCode() { return "Policy Hidden"; }

    public abstract double EstimateRental(int totalDays);
}

// Car rental class
public class AutoCab : TransportUnit, IInsurable
{
    public override double EstimateRental(int totalDays) => DayCharge * totalDays;
    public double ComputeCoverageCharge() => DayCharge * 2.5;
    public string ShowCoveragePlan() => "Coverage → Car Plan";
}

// Bike rental class
public class MotoRide : TransportUnit, IInsurable
{
    public override double EstimateRental(int totalDays) => (DayCharge * totalDays) - 100;
    public double ComputeCoverageCharge() => DayCharge * 1.2;
    public string ShowCoveragePlan() => "Coverage → Bike Plan";
}

// Truck rental class
public class HeavyLoadRide : TransportUnit, IInsurable
{
    public override double EstimateRental(int totalDays) => (DayCharge * totalDays) + 500;
    public double ComputeCoverageCharge() => DayCharge * 4.0;
    public string ShowCoveragePlan() => "Coverage → Truck Plan";
}

// Main menu engine
public class RentalMenuEngine
{
    private static TransportUnit[] rentFleet = new TransportUnit[10];
    private static int filled = 0;

    public static void AddVehicleOption()
    {
        if (filled >= rentFleet.Length)
        {
            Console.WriteLine("Fleet storage full!\n");
            return;
        }

        Console.WriteLine("\nSelect Vehicle Kind:");
        Console.WriteLine("1 → Car");
        Console.WriteLine("2 → Bike");
        Console.WriteLine("3 → Truck");
        Console.Write("Your choice: ");

        int pick = Convert.ToInt32(Console.ReadLine());
        TransportUnit unit;

        if (pick == 1) unit = new AutoCab();
        else if (pick == 2) unit = new MotoRide();
        else if (pick == 3) unit = new HeavyLoadRide();
        else
        {
            Console.WriteLine("Invalid vehicle choice!\n");
            return;
        }

        Console.Write("Enter Registration Number: ");
        string mark = Console.ReadLine();

        Console.Write("Enter Rental Charge per Day: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Section Name: ");
        string sec = Console.ReadLine();

        Console.Write("Enter Insurance Policy Code: ");
        string pol = Console.ReadLine();

        unit.UpdateRegMark(mark);
        unit.UpdateDayCharge(rate);
        unit.UpdateCategory(sec);
        unit.StorePolicyCode(pol);

        rentFleet[filled++] = unit;
        Console.WriteLine("Vehicle added successfully!\n");
    }

    public static void ShowFleetOption()
    {
        if (filled == 0)
        {
            Console.WriteLine("\nNo vehicles available!\n");
            return;
        }

        Console.WriteLine("\n=== Vehicle Records ===");
        for (int i = 0; i < filled; i++)
        {
            Console.WriteLine($"{i + 1}. Reg → {rentFleet[i].RegMark} | Rate → ₹{rentFleet[i].DayCharge} | Section → {rentFleet[i].Category}");
        }
        Console.WriteLine();
    }

    public static void ComputeCostOption()
    {
        if (filled == 0)
        {
            Console.WriteLine("\nNo vehicles to compute cost!\n");
            return;
        }

        Console.Write("\nEnter number of rental days: ");
        int leaseDays = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n=== Rental Cost Breakdown ===");

        for (int i = 0; i < filled; i++)
        {
            TransportUnit unit = rentFleet[i];

            double rentCost = unit.EstimateRental(leaseDays);
            double coverCost = 0;
            string coverLabel = "No Coverage";

            if (unit is IInsurable safeUnit)
            {
                coverCost = safeUnit.ComputeCoverageCharge();
                coverLabel = safeUnit.ShowCoveragePlan();
            }

            Console.WriteLine("\n--- Cost Slip ---");
            Console.WriteLine("Reg Number  : " + unit.RegMark);
            Console.WriteLine("Daily Rate  : ₹" + unit.DayCharge);
            Console.WriteLine("Rent Total  : ₹" + rentCost);
            Console.WriteLine("Insurance   : ₹" + coverCost);
            Console.WriteLine(coverLabel);
            Console.WriteLine("--------------");
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("=== Vehicle Rental Console ===");
            Console.WriteLine("1 → Add Vehicle");
            Console.WriteLine("2 → View Vehicles");
            Console.WriteLine("3 → Calculate Rent + Insurance");
            Console.WriteLine("4 → Exit");
            Console.Write("Enter option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1) AddVehicleOption();
            else if (choice == 2) ShowFleetOption();
            else if (choice == 3) ComputeCostOption();
            else if (choice == 4)
            {
                Console.WriteLine("\nConsole Closed.");
                break;
            }
            else Console.WriteLine("\nWrong option! Try again.\n");
        }
    }
}
