using System;

class Student
{
    // static variable shared among all students
    public static string universityName = "Everest State University";
    private static int enrolledCount = 0;

    // readonly Roll Number (fixed once assigned)
    public readonly int rollNumber;

    
    public string name;
    public string grade;

    // constructor 
    public Student(string name, int rollNumber, string grade)
    {
        this.name = name;
        this.rollNumber = rollNumber; // assigned to readonly field
        this.grade = grade;
        enrolledCount++;
    }

    // static method to display total students
    public static void DisplayTotalStudents()
    {
        Console.WriteLine("\nTotal Students in " + universityName + " : " + enrolledCount);
    }

    // method to update grade (only inside object)
    public void ModifyGrade(string newGrade)
    {
        this.grade = newGrade;
    }

    // method to print student details
    public void PrintStudentCard()
    {
        Console.WriteLine("\n--- Student Record ---");
        Console.WriteLine("University : " + universityName);
        Console.WriteLine("Name       : " + name);
        Console.WriteLine("Roll No.   : " + rollNumber);
        Console.WriteLine("Grade      : " + grade);
        Console.WriteLine("---------------------");
    }
}

class CampusApp
{
    public static void Main()
    {
        Console.WriteLine("Enter Student Name:");
        string sName = Console.ReadLine();

        Console.WriteLine("Enter Roll Number:");
        int sRoll = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Grade:");
        string sGrade = Console.ReadLine();

        Student stud = new Student(sName, sRoll, sGrade);

        Console.WriteLine("\nVerifying object type using 'is' operator...");

        // is operator check before printing
        if (stud is Student)
        {
            Console.WriteLine("Check OK: Object belongs to Student class.");
            stud.PrintStudentCard();
        }

        Console.WriteLine("\nDo you want to update grade? (yes/no)");
        string choice = Console.ReadLine()?.ToLower() ?? "no";

        if (choice == "yes")
        {
            Console.WriteLine("Enter New Grade:");
            string g = Console.ReadLine();

            // check again using is before update
            if (stud is Student)
                stud.ModifyGrade(g);

            Console.WriteLine("\nUpdated details...");
            stud.PrintStudentCard();
        }

        // static method call
        Student.DisplayTotalStudents();
    }
}
