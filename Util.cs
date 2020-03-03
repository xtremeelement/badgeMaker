using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Util
    {
        //Function to iterate through the employee list and prints to console
        public static void PrintEmployees(List<Employee> employees)
        {
            // foreach (Employee employee in employees)
            // {
            //     Console.WriteLine(employee.GetName());
            // }

            for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
            }
        }
    }
}