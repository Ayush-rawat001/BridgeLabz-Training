using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace EmployeeWage.Employee
{
    public interface IEmployeeWork
    {
        void AddEmployee(Employee employeeData);
    }
    public class Employee
    {
        private string employeeId;
        private string employeeName;
        public void SetId(string i) { employeeId = i; }
        public string GetId() { return employeeId; }

        public void SetName(string n) { employeeName = n; }
        public string GetName() { return employeeName; }

        public override string ToString()
        {
            return "employee name is "+GetName()+" employee id is"+GetId();
        }
    }
}
