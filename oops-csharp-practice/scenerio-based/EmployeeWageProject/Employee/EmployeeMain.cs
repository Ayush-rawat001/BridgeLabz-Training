using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeWage.Employee;

namespace EmployeeWage.Employee
{
    public class EmployeeMain
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch\n");

            EmployeeMenu menu = new EmployeeMenu();
            menu.StartMenu();

            Console.WriteLine("Thank You for using the system!");
        }
    }
}
