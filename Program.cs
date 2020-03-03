using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {

        //Function to add employees to the list;
        static List<string> GetEmployees()
        {
            List<string> employees = new List<string>();

            while (true)
            {
                Console.WriteLine("Please enter a name or leave blank to exit:\n");
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }

                //Instantiate new employee from Employee.cs to create a new Employee instance
                Employee currentEmployee = new Employee(input, "Smith");
                //Adds the employees name by using the GetName method from Employee.cs using the parameters passed in above
                employees.Add(currentEmployee.GetName());
            }

            return employees;
        }

        //Function to iterate through the employee list and prints to console
        static void PrintEmployees(List<string> employees)
        {
            foreach (string employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        //Entry point to application
        static void Main(string[] args)
        {
            //Calls the GetEmployees function
            List<string> employees = GetEmployees();

            //Calls the PrintEmployees function passing the employees as a parameter
            PrintEmployees(employees);
        }
    }
}
