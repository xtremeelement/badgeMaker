using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {

        //Function to add employees to the list;
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            while (true)
            {
                Console.WriteLine("Please enter a name or leave blank to exit:");
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }

                //Instantiate new employee from Employee.cs to create a new Employee instance
                Employee currentEmployee = new Employee(input, "Smith");
                //Adds the employees name by using the GetName method from Employee.cs using the parameters passed in above
                employees.Add(currentEmployee);
            }

            return employees;
        }

        //Function to iterate through the employee list and prints to console
        static void PrintEmployees(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.GetName());
            }

            // for (int i = 0; i < employees.Count; i++)
            // {         
            //     Console.WriteLine(employees[i].GetName());
            // }
        }

        //Entry point to application
        static void Main(string[] args)
        {
            //Calls the GetEmployees function
            List<Employee> employees = GetEmployees();

            //Calls the PrintEmployees function passing the employees as a parameter
            PrintEmployees(employees);
        }
    }
}
