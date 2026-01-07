using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeWage.Employee;
namespace EmployeeWage.Employee
{
    public class EmployeeUtility : IEmployeeWork
    {
         private Employee[] staff = new Employee[50]; // fixed size storage
        private int count = 0;

        public void AddEmployee(Employee employeeData)
        {
            if (count < staff.Length)
            {
                staff[count] = employeeData;
                count++;
                Console.WriteLine("Employee stored!\n");
            }
            else
            {
                Console.WriteLine("Storage full!\n");
            }
        }

       public void checkAttendence(){
         Console.WriteLine("---- Attendance Report ----");

    if (count == 0)
    {
        Console.WriteLine("No employees added yet!\n");
        return;
    }

    Random random = new Random();

    for (int i = 0; i < count; i++)
    {
        int attendance = random.Next(0, 2); // generates 0 or 1

        if (attendance == 1)
        {
            Console.WriteLine(staff[i].GetName() + " is Present");
        }
        else
        {
            Console.WriteLine(staff[i].GetName() + " is Absent");
        }
    }

    Console.WriteLine();
       }
        public void ListEmployees()
        {
            Console.WriteLine("---- Employee List ----");
            if (count == 0)
            {
                Console.WriteLine("No data available!\n");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(staff[i]);
            }
            Console.WriteLine();
        }
    }
}
