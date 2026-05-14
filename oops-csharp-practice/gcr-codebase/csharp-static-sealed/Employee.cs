using System;

class Employee
{
    // static variable shared among all employees
    public static string companyName = "Vertex Tech Solutions";
    private static int totalEmployees = 0;

    // readonly employee ID (fixed after assignment)
    public readonly int id;

   
    public string name;
    public string designation;

    
    public Employee(string name, int id, string designation)
    {
        this.name = name;
        this.id = id;
        this.designation = designation;
        totalEmployees++;
    }

    // static method to display total employees
    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("\nTotal Employees at " + companyName + " : " + totalEmployees);
    }

    // method to print employee details
    public void PrintEmployeeData()
    {
        Console.WriteLine("\n--- Employee Profile ---");
        Console.WriteLine("Company : " + companyName);
        Console.WriteLine("Name    : " + name);
        Console.WriteLine("Role    : " + designation);
        Console.WriteLine("ID      : " + id);
        Console.WriteLine("-----------------------");
    }
}

class RunOffice
{
    public static void Main()
    {
        Console.WriteLine("Enter Employee Name:");
        string eName = Console.ReadLine();

        Console.WriteLine("Enter Employee ID (number):");
        int eId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Designation:");
        string eDesig = Console.ReadLine();

        Employee emp = new Employee(eName, eId, eDesig);

        Console.WriteLine("\nValidating object type using 'is' operator...");
        
        // is operator check
        if (emp is Employee)
        {
            Console.WriteLine("Check Passed: Object is an Employee instance.");
            emp.PrintEmployeeData();
        }

        // static method call using class name
        Employee.DisplayTotalEmployees();
    }
}
