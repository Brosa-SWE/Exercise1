using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        private static bool continueInput = true;
        private static EmployeeRegister employees = new EmployeeRegister();


        static void Main(string[] args)
        {

            Console.WriteLine("PersonalRegister");
            Console.WriteLine("----------------");
            Console.WriteLine("Avsluta inmatning med bara Enter i namnfältet");

            do
            {
                AddEmployee();
            } while (continueInput);

            employees.printRegister();
            Console.ReadKey();

        }

        private static void AddEmployee()
        {
            Console.Write("Namn: ");
            string empName = Console.ReadLine();

            if (empName == "")
            {
                continueInput = false;
            }
            else
            {
                Console.Write("Lön: ");
                int empSalary = Int32.Parse(Console.ReadLine());

                employees.addEmployee(empName, empSalary);

            }
        }
    }
}