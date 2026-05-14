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

        public void CheckDailyWage()
        {
            Console.WriteLine("---- Daily Wage ----");
            if (count == 0)
            {
                Console.WriteLine("No employees!\n");
                return;
            }

            Random random = new Random();
            int wagePerHour = 20;
            int fullDayHour = 8;

            for (int i = 0; i < count; i++)
            {
                int attendance = random.Next(0, 2);
                int dailyWage = 0;

                switch (attendance)
                {
                    case 1:
                        dailyWage = wagePerHour * fullDayHour;
                        Console.WriteLine(staff[i].GetName() + " → Present | Earned Today");
                        break;
                    case 0:
                        Console.WriteLine(staff[i].GetName() + " → Absent | No Pay");
                        break;
                }

                if (attendance == 1)
                {
                    Console.WriteLine("Calculated Wage: ₹" + dailyWage + "\n");
                }
            }
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

        public void ShowPartTime()
        {
            Employee emp =new Employee();
            Random random = new Random();

             for (int i = 0; i < count; i++)
             {
                 int check = random.Next(0, 2);

                 switch(check)
                 {
                    case 1:
                        emp.DailyWage=emp.FullTimeHour*emp.HourlyWage;
                        Console.WriteLine(staff[i].GetName()+" is a full time employee and its wage is "+ emp.DailyWage);
                        break;
                    case 0:
                        emp.DailyWage=emp.PartTimeHour*emp.HourlyWage;
                        Console.WriteLine(staff[i].GetName()+" is a Part time employee and its wage is "+ emp.DailyWage);
                        break;
                 }
            }
        }

        public void MonthlyWage()
        {
            if(count==0){
                Console.WriteLine("No employee");
                return ;
            }
            Employee emp =new Employee();
        for (int i = 0; i < count; i++)
        {    
            Console.WriteLine("how many days "+ staff[i].GetName() + " is present :");
            int days =Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("how many hours "+ staff[i].GetName() + " has worked every day:");
            int hours =Convert.ToInt32(Console.ReadLine());

            int TotalHours=days*hours;

            if(TotalHours>=100||days>=20)
            {
              Console.WriteLine(staff[i].GetName()+" monthly wage is "+ (TotalHours)*emp.HourlyWage);
            }
           else
            {
              bool LessHours= TotalHours<100;

              bool LessDays= days<20;

            if(LessHours && LessDays)Console.WriteLine(staff[i].GetName()+" has both less working days and less working hours");
            else if(LessDays)Console.WriteLine(staff[i].GetName()+" has less working days");
            else Console.WriteLine(staff[i].GetName()+" has less working hours");
             }

        }
           
        }
    }
}
