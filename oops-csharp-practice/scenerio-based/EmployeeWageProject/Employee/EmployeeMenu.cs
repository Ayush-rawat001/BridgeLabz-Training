using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeWage.Employee;
namespace EmployeeWage.Employee
{
   

    public class EmployeeMenu
    {
        private EmployeeUtility utilObj = new EmployeeUtility();

        public void StartMenu()
        {
            while (true)
            {
                Console.WriteLine("===== Employee Wage Panel =====");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Check Attendance");
                Console.WriteLine("3. check daily wage");
                Console.WriteLine("4. list Employee");
                Console.WriteLine("5. check part time");
                 Console.WriteLine("6. monthly wage");
                Console.WriteLine("7. Close App");
                Console.Write("Enter option: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (choice == 1)
                {
                    Employee empObj = new Employee();

                    Console.Write("Enter Employee Code: ");
                    empObj.SetId(Console.ReadLine());

                    Console.Write("Enter Employee Name: ");
                    empObj.SetName(Console.ReadLine());
                    
                    utilObj.AddEmployee(empObj);
                }
                else if (choice == 2)
                {
                    utilObj.checkAttendence();
                }
                else if (choice == 3)
                {
                    utilObj.CheckDailyWage();
                }
                else if (choice == 4)
                {
                    utilObj.ListEmployees();
                }
                else if (choice == 5)
                {
                    utilObj.ShowPartTime();
                }
                else if (choice == 6)
                {
                    utilObj.MonthlyWage();
                }
                else if (choice == 7)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option!\n");
                }
            }
        }
    }

}
