using System;

public interface IPayable
{
    double PayBill();
}

class Patient : IPayable
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Patient(string n, int a)
    {
        name = n;
        age = a;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Patient Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    public virtual double PayBill()
    {
        return 0;
    }
}

class InPatient : Patient
{
    private int days;
    private double dayCharge = 400;

    public InPatient(string n, int a, int d) : base(n, a)
    {
        days = d;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Patient Type: In-Patient");
        Console.WriteLine("Hospital Stay Days: " + days);
    }

    public override double PayBill()
    {
        return days * dayCharge;
    }
}

class OutPatient : Patient
{
    private double checkupFee = 250;

    public OutPatient(string n, int a) : base(n, a) { }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Patient Type: Out-Patient");
        Console.WriteLine("Checkup Fee: ₹" + checkupFee);
    }

    public override double PayBill()
    {
        return checkupFee;
    }
}

class Doctor
{
    private string docName;

    public string DocName
    {
        get { return docName; }
        set { docName = value; }
    }

    public Doctor(string d)
    {
        docName = d;
    }

    public void DisplayDoctor()
    {
        Console.WriteLine("Doctor Name: " + docName);
    }
}

class Bill
{
    public void PrintBill(double amount)
    {
        Console.WriteLine("\n--- Bill Details ---");
        Console.WriteLine("Total Amount to Pay: ₹" + amount);
        Console.WriteLine("------------------\n");
    }
}

class HospitalApp
{
    static void Main()
    {
        Doctor d1 = new Doctor("Dr. Sharma");
        Patient p1 = new InPatient("Ayush Rawat", 22, 2);
        Patient p2 = new OutPatient("Amit", 20);

        d1.DisplayDoctor();
        p1.DisplayInfo();
        Bill b = new Bill();
        b.PrintBill(p1.PayBill());

        d1.DisplayDoctor();
        p2.DisplayInfo();
        b.PrintBill(p2.PayBill());
    }
}
