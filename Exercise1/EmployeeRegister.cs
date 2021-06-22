using System;
using System.Collections.Generic;

namespace Exercise1
{
    class EmployeeRegister
    {
        public void addEmployee(string empName, int empSalary)
        {
            Employee newEmployee = new Employee(empName, empSalary);
            employees.Add(newEmployee);

        }

        public void printRegister()
        {
            Console.WriteLine();
            Console.WriteLine("Employee Register");
            Console.WriteLine("-----------------");

            foreach (Employee employee in employees)
                {
                Console.WriteLine(employee.getEmployeeInfo());
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        private List<Employee> employees = new List<Employee>();
    }


}