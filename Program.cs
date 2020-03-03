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
                string firstName = Console.ReadLine();

                if (firstName == "")
                {
                    break;
                }

                Console.WriteLine("Enter Last Name:");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter ID:");
                int id = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter Photo URL:");
                string photoUrl = Console.ReadLine();

                //Instantiate new employee from Employee.cs to create a new Employee instance
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                //Adds the employees name by using the GetName method from Employee.cs using the parameters passed in above
                employees.Add(currentEmployee);
            }

            return employees;
        }

        //Entry point to application
        static void Main(string[] args)
        {
            //Calls the GetEmployees function
            List<Employee> employees = GetEmployees();

            //Calls the PrintEmployees function passing the employees as a parameter
            Util.PrintEmployees(employees);
        }
    }
}
