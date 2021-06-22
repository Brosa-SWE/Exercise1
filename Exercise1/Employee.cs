using System;

namespace Exercise1
{
    internal class Employee
    {

        public Employee(string empName, int empSalary)
        {
            this.empName = empName;
            this.empSalary = empSalary;
          
        }

        public string getEmployeeInfo()
        {
            return (empName + " " + empSalary);
        }
     
        private string empName;
        private int empSalary;

}



}