using System;

// Base class
class Worker
{
    public string Name;
    public int Id;
    public double Salary;

    public Worker(string name, int id, double salary)
    {
        this.Name = name;
        this.Id = id;
        this.Salary = salary;
    }

    // Method to display basic employee details
    public virtual void ShowDetails()
    {
        Console.WriteLine($"Name: {Name}, ID: {Id}, Salary: {Salary}");
    }
}

// Manager subclass
class Manager : Worker
{
    public int TeamSize;

    public Manager(string name, int id, double salary, int teamSize) 
        : base(name, id, salary)
    {
        this.TeamSize = teamSize;
    }

    public override void ShowDetails()
    {
        Console.WriteLine($"Manager: {Name}, ID: {Id}, Salary: {Salary}, Team Size: {TeamSize}");
    }
}

// Developer subclass
class Developer : Worker
{
    public string Language;

    public Developer(string name, int id, double salary, string language) 
        : base(name, id, salary)
    {
        this.Language = language;
    }

    public override void ShowDetails()
    {
        Console.WriteLine($"Developer: {Name}, ID: {Id}, Salary: {Salary}, Language: {Language}");
    }
}

// Intern subclass
class Intern : Worker
{
    public string Duration;

    public Intern(string name, int id, double salary, string duration) 
        : base(name, id, salary)
    {
        this.Duration = duration;
    }

    public override void ShowDetails()
    {
        Console.WriteLine($"Intern: {Name}, ID: {Id}, Salary: {Salary}, Internship Duration: {Duration}");
    }
}

// Main program
class EmployeeProgram
{
    public static void Main()
    {
        Manager manager1 = new Manager("Ayush", 101, 90000, 5);
        Developer dev1 = new Developer("Bharat", 102, 70000, "C#");
        Intern intern1 = new Intern("rohit", 103, 20000, "3 months");

        manager1.ShowDetails();
        dev1.ShowDetails();
        intern1.ShowDetails();
    }
}
