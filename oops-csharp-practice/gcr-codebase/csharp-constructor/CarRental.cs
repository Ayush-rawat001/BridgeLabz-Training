using System;

class AutoHire
{
    // shared attributes
    public string client;
    public string vehicle;
    public int tenure;
    public double dailyCharge = 1350.0; // per day rent

    // constructor
    public AutoHire(string client, string vehicle, int tenure)
    {
        this.client = client;
        this.vehicle = vehicle;
        this.tenure = tenure;
        this.dailyCharge = CalcDailyRate(vehicle);
    }

    // decides rate by car category
    private double CalcDailyRate(string model)
    {
        string m = model.ToLower();
        if (m.Contains("tesla")) return 2200;
        if (m.Contains("suv")) return 1600;
        if (m.Contains("lux")) return 3000;
        return 1350; // default
    }

    // print invoice
    public void BillSlip()
    {
        double sum = tenure * dailyCharge;
        Console.WriteLine("\n===== BILL SLIP =====");
        Console.WriteLine("Renter   : " + client);
        Console.WriteLine("Car      : " + vehicle);
        Console.WriteLine("Days     : " + tenure);
        Console.WriteLine("Per Day  : ₹" + dailyCharge);
        Console.WriteLine("Payable  : ₹" + sum);
        Console.WriteLine("=====================\n");
    }
}

class ConsoleApp
{
    public static void Main()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine() ?? "";

        Console.WriteLine("Enter car name/model:");
        string car = Console.ReadLine() ?? "";

        Console.WriteLine("Enter number of days:");
        int day = Convert.ToInt32(Console.ReadLine());

        AutoHire rent = new AutoHire(name, car, day);
        rent.BillSlip();
    }
}
