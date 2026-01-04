using System;

class Employee
{
    string fullName;
    int empCode;
    double monthlyPay;

    public Employee(string name, int code, double pay)
    {
        fullName = name;
        empCode = code;
        monthlyPay = pay;
    }

    public void Show()
    {
        Console.WriteLine("\n--- Staff Information ---");
        Console.WriteLine("Name    : " + fullName);
        Console.WriteLine("ID      : " + empCode);
        Console.WriteLine("Salary  : ₹" + monthlyPay);
        Console.WriteLine("------------------------");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter employee name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter employee ID:");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter salary amount:");
        double salary = Convert.ToDouble(Console.ReadLine());

        Employee s1 = new Employee(name, id, salary);
        s1.Show();
    }
}
