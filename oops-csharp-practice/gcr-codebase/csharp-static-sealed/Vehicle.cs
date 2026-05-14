using System;

class Vehicle
{
    // static variable shared across all vehicles
    public static double registrationFee = 550.0;
    
    // readonly unique registration number
    public readonly string registrationNumber;

    // instance variables
    public string ownerName;
    public string vehicleType;

    // constructor using this
    public Vehicle(string ownerName, string vehicleType, string registrationNumber)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
        this.registrationNumber = registrationNumber;
        this.registrationNumber = registrationNumber; // assigning to readonly field
    }

    // static method to update registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        if (newFee > 0)
            registrationFee = newFee;
    }

    // method to display registration details
    public void PrintRegistration()
    {
        Console.WriteLine("\n--- Vehicle Registration ---");
        Console.WriteLine("Owner  : " + ownerName);
        Console.WriteLine("Type   : " + vehicleType);
        Console.WriteLine("Reg No.: " + registrationNumber);
        Console.WriteLine("Fee    : ₹" + registrationFee);
        Console.WriteLine("----------------------------");
    }
}

class TransportApp
{
    public static void Main()
    {
        Console.WriteLine("Enter Owner Name:");
        string vOwner = Console.ReadLine();

        Console.WriteLine("Enter Vehicle Type:");
        string vType = Console.ReadLine();

        Console.WriteLine("Enter Registration Number:");
        string vRegNo = Console.ReadLine();

        Vehicle myVehicle = new Vehicle(vOwner, vType, vRegNo);

        Console.WriteLine("\nValidating object using 'is' operator...");

        // is operator check before displaying details
        if (myVehicle is Vehicle)
        {
            Console.WriteLine("Validation Passed: This is a Vehicle object.");
            myVehicle.PrintRegistration();
        }

        Console.WriteLine("\nWant to update registration fee for all vehicles? Enter new fee:");
        double fee = Convert.ToDouble(Console.ReadLine());

        Vehicle.UpdateRegistrationFee(fee);

        Console.WriteLine("\nRechecking instance type before printing updated details...");

        if (myVehicle is Vehicle)
            myVehicle.PrintRegistration();
    }
}
