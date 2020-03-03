using System;
using System.Collections.Generic;
using System.IO;

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

        //Method to create csv file which will store our data
        public static void MakeCSV(List<Employee> employees)
        {
            //Create data folder if it doesnt exist
            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");
            }

            //Using the new directory with csv file, write each employee to the csv file
            using (StreamWriter file = new StreamWriter("data/employees.csv"))
            {
                file.WriteLine("ID,Name,PhotoURL");

                foreach (Employee employee in employees)
                {
                    file.WriteLine($"{employee.GetName()},{employee.GetId()},{employee.GetPhotoUrl()}");
                }
            }
        }
    }
}