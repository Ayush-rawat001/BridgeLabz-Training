using System;

class TransportInfo
{
    // instance variables
    public string holder;
    public string category;

    // class variable
    public static double regCharge = 950.0;

    // constructor
    public TransportInfo(string holder, string category)
    {
        this.holder = holder;
        this.category = category;
    }

    // instance method
    public void PrintVehicle()
    {
        Console.WriteLine("\nOwner Name    : " + holder);
        Console.WriteLine("Vehicle Type  : " + category);
        Console.WriteLine("Reg Fee       : ₹" + regCharge);
    }

    // class method
    public static void ChangeRegFee(double newFee)
    {
        regCharge = newFee;
    }
}

class DriveApp
{
    public static void Main()
    {
        Console.WriteLine("Enter owner name:");
        string o = Console.ReadLine() ;

        Console.WriteLine("Enter vehicle type:");
        string v = Console.ReadLine() ;

        Console.WriteLine("Enter updated registration fee:");
        double u = Convert.ToDouble(Console.ReadLine());
        TransportInfo.ChangeRegFee(u);

        TransportInfo t = new TransportInfo(o, v);
        t.PrintVehicle();
    }
}
