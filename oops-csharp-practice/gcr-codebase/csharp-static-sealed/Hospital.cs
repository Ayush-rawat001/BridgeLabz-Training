using System;

class Patient
{
    // static variable shared across all patients
    public static string HospitalName = "CityCare Hospital";

    // static counter to keep track of total patients
    private static int totalPatients = 0;

    // readonly unique patient ID
    public readonly string PatientID;

    // instance variables
    public string Name;
    public int Age;
    public string Ailment;

    // constructor using this
    public Patient(string id, string name, int age, string ailment)
    {
        this.PatientID = id;
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;

        totalPatients++; // increment total patients on each new admission
    }

    // static method to get total patients admitted
    public static int GetTotalPatients()
    {
        return totalPatients;
    }

    // method to display patient details
    public void DisplayDetails()
    {
        Console.WriteLine("\n--- Patient Details ---");
        Console.WriteLine("Patient ID : " + PatientID);
        Console.WriteLine("Name       : " + Name);
        Console.WriteLine("Age        : " + Age);
        Console.WriteLine("Ailment    : " + Ailment);
        Console.WriteLine("Hospital   : " + HospitalName);
        Console.WriteLine("------------------------");
    }
}

class HospitalApp
{
    public static void Main()
    {
        // create a few patient objects
        Patient p1 = new Patient("P001", "Ravi", 30, "Fever");
        Patient p2 = new Patient("P002", "Anjali", 25, "Cancer");

        // is operator check before displaying
        if (p1 is Patient) p1.DisplayDetails();
        if (p2 is Patient) p2.DisplayDetails();

        // display total patients admitted
        Console.WriteLine("\nTotal Patients Admitted: " + Patient.GetTotalPatients());
    }
}
