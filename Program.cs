using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        //Entry point to application
        static void Main(string[] args)
        {
            //Calls the GetEmployees function
            List<string> employees = GetEmployees();

            //Calls the PrintEmployees function passing the employees as a parameter
            PrintEmployees(employees);
        }

        //Function to add employees to the list;
        static List<string> GetEmployees()
        {
            List<string> employees = new List<string>();

            while (true)
            {
                Console.WriteLine("Please enter a name:\n");
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }

                employees.Add(input);
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
    }
}
